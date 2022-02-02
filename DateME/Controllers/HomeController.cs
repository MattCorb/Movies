using DateME.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private DateApplicationContext MVContext { get; set; }
        public HomeController(DateApplicationContext someName)
        {
            MVContext = someName;
        }
        //initial index view
        public IActionResult Index()
        {
            return View();
        }
        //Movie form get
        [HttpGet]
        public IActionResult FillOutApplication()
        {
            ViewBag.Categories = MVContext.Categories.ToList();
            return View("DatingApplication");
        }

        //Movie form post
        [HttpPost]
        public IActionResult FillOutApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                MVContext.Add(ar);
                MVContext.SaveChanges();
                return View("Index", ar);
            }
            else
            {
                ViewBag.Categories = MVContext.Categories.ToList();
                return View("DatingApplication");
            }

        }

        //Podcast view
        [HttpGet]
        public IActionResult Confirmation()
        {
            return View("Confirmation");
        }




        public IActionResult WatchedList()
        {
            var applications = MVContext.Responses.Include(x => x.Category)
                .Where(x => x.Edited == false)
                .OrderBy(x => x.Year)
                .ToList();
            return View(applications);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = MVContext.Categories.ToList();
            ViewBag.Edit = true;
            var application = MVContext.Responses.Single(x => x.ApplicationId == id);
            return View("DatingApplication", application);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse Movie)
        {
            if (ModelState.IsValid)
            {
                MVContext.Update(Movie);
                MVContext.SaveChanges();
                return RedirectToAction("WatchedList");
            }
            else
            {
                ViewBag.Categories = MVContext.Categories.ToList();
                return View("DatingApplication");
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = MVContext.Responses.Single(x => x.ApplicationId == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse movie)
        {
            MVContext.Responses.Remove(movie);
            MVContext.SaveChanges();
            return RedirectToAction("WatchedList");
        }


    }



}
