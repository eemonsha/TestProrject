using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Data;
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
            return View();
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

        //[HttpPost]
        //public IActionResult StudentCreate()
        //{
        //    return View();
        //}
    }
}
