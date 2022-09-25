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

            var courseprice = _context.Departments.Where(x => x.DepartmentID == course.DepartID).FirstOrDefault();
            var pp = courseprice.DepartmentCreditPrice * course.Coursecredit;
            course.CoursePrice = pp;
            _context.Courses.Add(course);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Course Added");

            return RedirectToAction("CourseIndex");
        }

        public JsonResult DepartmentCrt(Department data)
        {
            _context.Departments.Add(data);
            _context.SaveChanges();
            var dpt = _context.Departments.OrderByDescending(x => x.DepartmentID).ToList();
            return Json(dpt);

        }

        public JsonResult DepCrditPrice(int depid)
        {
            var deprice = _context.Departments.FirstOrDefault(x => x.DepartmentID == depid).DepartmentCreditPrice;
            return Json(deprice);
        }

    }
}
