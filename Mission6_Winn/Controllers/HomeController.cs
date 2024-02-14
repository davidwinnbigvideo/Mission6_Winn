using Microsoft.AspNetCore.Mvc;
using Mission6_Winn.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6_Winn.Controllers
{
    public class HomeController : Controller
    {
        private FormContext _context;

        public HomeController(FormContext temp)
        {
            //This passes the database to the private model
            _context = temp;
        }

        // Get Index
        public IActionResult Index()
        {
            return View();
        }

        // Get About
        public IActionResult About()
        {
            return View();
        }

        // Get Form
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        // Posts the filled out form and displays a confirmation page
        [HttpPost]
        public IActionResult Form(Models.Application response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }
    }
}
