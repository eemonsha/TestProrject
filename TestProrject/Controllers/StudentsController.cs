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
                stdnt.RemainBalance = stdnt.Balance;
                stdnt.StudentScore = student.StudentScore;
                stdnt.ISActive = student.ISActive;
                stdnt.StudentStatus = student.StudentStatus = "NEW";
                stdnt.PPicture = uniqueFileName;


                _context.Students.Add(stdnt);
                _context.SaveChanges();
                _toastNotification.AddSuccessToastMessage("Student Added");
                return RedirectToAction("StudentIndex");

            }
            else
            {
                TempData["msg"] = "Student ID Alrdy Exist";
            }
            return View();
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
