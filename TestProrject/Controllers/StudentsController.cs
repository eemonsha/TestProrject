using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Data;
using TestProrject.Models;
using TestProrject.ViewModel;

namespace TestProrject.Controllers
{
    public class StudentsController : Controller
    {

        private readonly DataContext _context;
        private readonly IToastNotification _toastNotification;
        private readonly IWebHostEnvironment webHostEnvironment;

        public StudentsController(DataContext context, IToastNotification toastNotification , IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _toastNotification = toastNotification;
            webHostEnvironment = hostEnvironment;

        }
        public IActionResult StudentIndex()
        {
            var stulist = _context.Students.ToList();
            var viewmodel = new List<StudentVM>();
            var model = new StudentVM();

            foreach (var item in   stulist)
            {
                model = new StudentVM
                {
                    StudentID = item.StudentID,
                    StudentName = item.StudentName,
                    StudentIDentity = item.StudentIDentity,
                    StudentPicture = item.PPicture
                };
                viewmodel.Add(model);
            }
            return View(viewmodel);
        }

        public IActionResult StudentCreate()
        {
            IEnumerable<SelectListItem> dep = from Department in _context.Departments.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Department.DepartmentID.ToString(),
                                                  Text = Department.DepartmentName
                                              };
            ViewBag.deepart = dep;



            var NewStudent = new StudentVM();
            NewStudent.Balance = 0;
            NewStudent.StudentScore = 0;
            return View(NewStudent);
        }

        [HttpPost]
        public IActionResult StudentCreate(StudentVM student)
        {
            

            
                var stuCode = _context.Students.Where(x => x.StudentIDentity == student.StudentIDentity).FirstOrDefault();

                if (stuCode == null)
                {
                    string uniqueFileName = UploadedFile(student);
                    var stdnt = new Student();

                    stdnt.StudentName = student.StudentName;
                    stdnt.StudentIDentity = student.StudentIDentity;
                    stdnt.DepID = student.DepID;
                    stdnt.Balance = student.Balance;
                    //stdnt.RemainBalance = stdnt.Balance;
                    stdnt.RemainBalance = student.RemainBalance;
                    stdnt.StudentScore = student.StudentScore;
                    stdnt.ISActive = student.ISActive;
                    stdnt.StudentStatus = student.StudentStatus = "NEW";
                    stdnt.PPicture = uniqueFileName;


                var depid = _context.Departments.Where(x => x.DepartmentID != student.DepartmentID).FirstOrDefault();
                var depscore = depid.DepartmentScore;
                if (depscore <= student.StudentScore)
                {

                    _context.Students.Add(stdnt);
                    _context.SaveChanges();
                    _toastNotification.AddSuccessToastMessage("Student Added");
                    return RedirectToAction("StudentIndex");

                }
                else
                {
                    TempData["mg"] = "Student Score Not able to this department";
                }
                }
             
               
                else
                {
                    TempData["msg"] = "Student ID Alrdy Exist";
                }

            


            
            return View();
        }


        public IActionResult Studentdetails(int id)
        {
            var sql = (from student in _context.Students.Where(x => x.StudentID == id)
                       join dep in _context.Departments
                       on student.DepID equals dep.DepartmentID
                       select new StudentVM
                       {
                           StudentName = student.StudentName,
                           StudentIDentity = student.StudentIDentity,
                           Balance = student.Balance,
                           RemainBalance = student.RemainBalance,
                           StudentScore = student.StudentScore,
                           StudentStatus = student.StudentStatus,
                           StudentPicture = student.PPicture,
                           DepartmentID = dep.DepartmentID,
                           DepartmentName = dep.DepartmentName,


                       }).FirstOrDefault();
                       

            return View(sql);
        }


        public IActionResult PAymentIndex()
        {
            var paylist = _context.PaymentRecharges.ToList();
            return View(paylist);
        }

        public IActionResult PaymentRecharge()
        {
            DefaultData();
            var payrcrg = new PaymentRecharge();
            payrcrg.PaymentAmount = 0;
            payrcrg.PaymentDate = System.DateTime.Now;

            return View();
        }


        private void DefaultData()
        {
            
            

            IEnumerable<SelectListItem> stu = from Student in _context.Students.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Student.StudentID.ToString(),
                                                  Text = Student.StudentIDentity + "_" + Student.StudentName
                                              };
            ViewBag.stu = stu;
        }

        [HttpPost]
        public IActionResult PaymentRecharge(PaymentRecharge paymentRecharge)
        {
            if (paymentRecharge.PStudentID == 0)
            {
                _toastNotification.AddErrorToastMessage("Please specify Student");
                DefaultData();//loading default data
                return View(paymentRecharge);
            }

            var tk = _context.Students.Where(x => x.StudentID == paymentRecharge.PStudentID).FirstOrDefault();
            tk.RemainBalance = tk.RemainBalance + paymentRecharge.PaymentAmount;
            _context.Update(tk);
            _context.SaveChanges();

            _context.PaymentRecharges.Add(paymentRecharge);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Payment Added");

            return RedirectToAction("PAymentIndex");
        }

        public JsonResult GetStudentAmount(int stuid)
        {

            var rmnamn = _context.Students.FirstOrDefault(x => x.StudentID == stuid).RemainBalance;
            return Json(rmnamn);


        }
       
        public JsonResult Getdepscore(int depid)
        {
            var score = _context.Departments.FirstOrDefault(x => x.DepartmentID == depid).DepartmentScore;
            return Json(score);
        }
        private string UploadedFile(StudentVM model)
        {
            string uniqueFileName = null;

            if (model.StudentImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/Student");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.StudentImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.StudentImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
