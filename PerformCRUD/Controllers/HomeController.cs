using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerformCRUD.Models;

namespace PerformCRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Call API to return List
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
       
            return View();
        }

        [HttpPost]
        public IActionResult CreateNew()
        {
            //Call API to post data
            //Redirect to Index
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update()
        {
            //Call API
            //return Result from API //Redirect to Index
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
