
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;


namespace MvcCoreLab1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            TempData["Location"] = "India";

            Student student = new Student
            {
                Id = 1,
                Name = "Priyanka",
                Gender = "Female"

            };
            ViewBag.CurrentDate = DateTime.Now.ToShortDateString();
            ViewData["Title"] = "Dr.";
            string? location = Convert.ToString(TempData["Location"]);
            return View(student);


        }
    }
}


