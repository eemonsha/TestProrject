using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Data;
using TestProrject.Models;

namespace TestProrject.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DataContext _context;
        private readonly IToastNotification _toastNotification;

        public DepartmentController(DataContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;

        }
        public IActionResult DepartmentIndex()
        {
            var depart = _context.Departments.ToList();
            return View(depart);
        }
        public IActionResult DepartmentCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmentCreate(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Department Added");
            return RedirectToAction("DepartmentIndex");
        }
    }
}
