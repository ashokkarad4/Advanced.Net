using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult food()
        {
            List<string> soptions = new List<string>();
            soptions.Add("Select an option");
            ViewData["soptions"] = new SelectList(soptions);
            List<string> noptions = new List<string>();
            noptions.Add("Select an option");
            ViewData["noptions"] = new SelectList(noptions);
            return View();
        }

        [HttpPost]
        public IActionResult Food(IFormCollection form, ICollection<string> soptions ,ICollection<string> noptions)
        {
            ViewBag.Name = form["name"];
            ViewBag.Mobile = form["mobileno"];
            ViewBag.South = soptions;
            ViewBag.SOption = form["soptions"];
            ViewBag.North = noptions;
            ViewBag.NOption = form["noptions"];
            return View("Order");
        }

    }
}
