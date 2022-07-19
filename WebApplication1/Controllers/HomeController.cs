using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "This is my MVC project";
            string[] names = { "Tushar", "Ashok", "Rohit", "Rahul" };

            ViewData["namelist"] = names;

            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Id=1,Name="Tushar",Department="IT",Salary=25000},
                 new Employee{Id=2,Name="Ashok",Department="IT",Salary=35000},
                  new Employee{Id=1,Name="Rahul",Department="Marketing",Salary=20000},
                   new Employee{Id=1,Name="Rohit",Department="Sales",Salary=24000},
                    new Employee{Id=1,Name="Ak",Department="BA",Salary=25000},
            };
            ViewData["emplist"] = emplist;
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
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
    }
}
