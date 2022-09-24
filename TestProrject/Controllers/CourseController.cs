using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Data;
using TestProrject.Models;

namespace TestProrject.Controllers
{



    public class CourseController : Controller
    {

        private readonly DataContext _context;
        private readonly IToastNotification _toastNotification;

        public CourseController(DataContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;

        }

        public IActionResult CourseIndex()
        {
            var course = _context.Courses.ToList();
            return View(course);
        }

        public IActionResult CourseCreate()
        {
            IEnumerable<SelectListItem> dep = from Department in _context.Departments.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Department.DepartmentID.ToString(),
                                                  Text = Department.DepartmentName
                                              };
            ViewBag.deepart = dep;


            return View();
        }

        [HttpPost]
        public IActionResult CourseCreate(Course course) 
        {


            _context.Courses.Add(course);
            _context.SaveChanges();

            return RedirectToAction("CourseIndex");
        }

        public JsonResult DepartmentCrt(Department data)
        {
            _context.Departments.Add(data);
            _context.SaveChanges();
            var dpt = _context.Departments.OrderByDescending(x => x.DepartmentID).ToList();
            return Json(dpt);

        }

    }
}
