using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProrject.Data;
using TestProrject.Models;
using TestProrject.ViewModel;

namespace TestProrject.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;


        public ProductController(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;


        }


        public IActionResult ProductIndex()
        {
            var ProList = _context.Products.ToList();
            var viewmodel = new List<ProductVM>();
            var model = new ProductVM();

            foreach (var item in ProList)
            {
                var SelQr = _context.QRs.Where(x => x.QrCategory == "Product" && x.ItemCode == item.Id).FirstOrDefault();
                var QrStatus = "No";
                if (SelQr != null)
                {
                    QrStatus = "Yes";
                }

                model = new ProductVM
                {
                    Id = item.Id,
                    ProductTittle = item.ProductTittle,
                    ProductCode = item.ProductCode,
                    SalesPrice = item.SalesPrice,
                    RemainingQty = item.RemainingQty,
                    QrExists = QrStatus
                };
                viewmodel.Add(model);
            }

            ViewData["products"] = viewmodel;
            return View(viewmodel);
        }



        public ActionResult CreateQr(int ProdID)
        {

            var SelProduct = _context.Products.Where(x => x.Id == ProdID).FirstOrDefault();

            var qrcodestring = Convert.ToString(ProdID) + "/" + SelProduct.ProductCode + "/" + SelProduct.ProductTittle + "/" + SelProduct.SalesPrice;
            int NoofQr = SelProduct.RemainingQty;

            var qrCodeGenerator = new QRCodeGenerator();
            //QRCodeData qRCodeData = qrCodeGenerator.CreateQrCode(qrcodestring, QRCodeGenerator.ECCLevel.Q);
            QRCodeData qRCodeData = qrCodeGenerator.CreateQrCode(qrcodestring, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap bitmap = qRCode.GetGraphic(3);
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("windows-1252");
            byte[] paramValue = null;
            using (var b = new Bitmap(qRCode.GetGraphic(3)))
            {
                using (var ms = new MemoryStream())
                {
                    b.Save(ms, ImageFormat.Bmp);
                    paramValue = ms.ToArray();
                }
            }

            for (int LoopMoover = 0; LoopMoover < SelProduct.RemainingQty; LoopMoover++)
            {
                var NewQr = new QRs()
                {
                    ID = 0,
                    ItemCode = ProdID,
                    QrImage = paramValue,
                    ItemName = SelProduct.ProductTittle,
                    PriceAmount = SelProduct.SalesPrice,
                    UserID = 1,
                    QrQty = 0,
                    QrCategory = "Product"
                };
                _context.Add(NewQr);
            }
            _context.SaveChanges();

            return RedirectToAction("ProductIndex");
        }

        public IActionResult PDeleteQr(int ProdID)
        {
            var SelQr = _context.QRs.Where(x => x.QrCategory == "Product" && x.ItemCode == ProdID).ToList();
            foreach (var items in SelQr)
            {
                _context.Remove(items);
                _context.SaveChanges();
            }


            return RedirectToAction("ProductIndex");
        }





        public IActionResult Productcreate()
        {
            
         
            return View();
        }

        [HttpPost]
        public IActionResult Productcreate(ProductVM product)
        {
            var procoe = _context.Products.Where(x => x.ProductCode == product.ProductCode).FirstOrDefault();
            if (procoe == null)
            {
                string uniqueFileName = UploadedFile(product);
                var salermnqty = new Product();

                salermnqty.InitialProductStockQty = product.InitialProductStockQty;

                salermnqty.RemainingQty = salermnqty.InitialProductStockQty;
                salermnqty.ProductCode = product.ProductCode;
                salermnqty.ProductTittle = product.ProductTittle;
           
                salermnqty.SalesPrice = product.SalesPrice;
                salermnqty.PPicture = uniqueFileName;
             
                



                _context.Products.Add(salermnqty);

                _context.SaveChanges();
                return RedirectToAction("ProductIndex");
            }
            else
            {
                TempData["msg"] = "Product Code Already Exist";
                return View();
            }
            return View();
        }

        public IActionResult EditProduct(int id)
        {

            var edit = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(edit);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {

            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction("ProductIndex");
        }

        public IActionResult ProductDetails(int id)
        {
            var sql = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(sql);

        }

        private string UploadedFile(ProductVM model)
        {
            string uniqueFileName = null;

            if (model.ProductImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProductImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProductImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }



    }
}
