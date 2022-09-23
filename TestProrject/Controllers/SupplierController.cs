using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Data;
using TestProrject.Models;

namespace TestProrject.Controllers
{
    public class SupplierController : Controller
    {
        private readonly DataContext _context;


        public SupplierController(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;


        }
        public IActionResult SuppliertIndex()
        {
            var supplier = _context.Suppliers.ToList();

            return View(supplier);
        }

        public IActionResult SupplierCrt()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SupplierCrt(Supplier supplier)
        {
            _context.Add(supplier);
            
            _context.SaveChanges();
            return RedirectToAction("SuppliertIndex");
        }

        public IActionResult SuPdetails(int id)
        {
            var subedit = _context.Suppliers.Where(l=> l.SupplierID == id).FirstOrDefault();
            return View(subedit);
        }

        public IActionResult Supdelete(int id)
        {
            var subdlt = _context.Suppliers.Where(l => l.SupplierID == id).FirstOrDefault();
            _context.Remove(subdlt);
            _context.SaveChanges();
            return RedirectToAction("SuppliertIndex");

        }

    }
}
