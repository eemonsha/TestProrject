using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestProrject.Data;
using TestProrject.Models;

namespace TestProrject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;
        
        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //login
        public IActionResult Login()
        {
            TempData["msg"] = "null";
            return View();
        }



        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            var user = _context.Users.Where(x => x.UserName == Username && x.PassWord == Password).FirstOrDefault();
            if (user != null)
            {

                return RedirectToAction("Index");

            }
            else
            {
                TempData["msg"] = "Wrong ID or Password";
                return View();
            }

        }






    }
}
