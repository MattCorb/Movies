using DateME.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateME.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DateApplicationContext _blahContext { get; set; } 
        public HomeController(ILogger<HomeController> logger, DateApplicationContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FillOutApplication()
        {
            return View("DatingApplication");
        }

        [HttpPost]
        public IActionResult FillOutApplication(ApplicationResponse ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();

            return View("Confirmation", ar);
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
