using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDTest.Models;
using CRUDTest.Helper;
//using CRUDApplication.Models;
using CRUDTest.Models;
using Newtonsoft.Json;
using System.Net.Http;
using CRUDTest.Data;

namespace CRUDTest.Controllers
{
    public class HomeController : Controller
    {
        StudentAPI _api = new StudentAPI();
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //private object jsonConvert;

        public async Task<IActionResult> Index()
        {
            List<Student> student = new List<Student>();
            HttpClient client = _api.Initial();
            HttpResponseMessage resp = await client.GetAsync("Students/GetStudent");
            if (resp.IsSuccessStatusCode)
            {
                var result = resp.Content.ReadAsStringAsync().Result;
                //student = jsonConvert.DeserializeObject<List<Student>>(result);
                student = JsonConvert.DeserializeObject<List<Student>>(result);
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student stud)
        {
            //Call API to post data
            //Redirect to Index
            //List<Student> student = new List<Student>();
            HttpClient client = _api.Initial();
            HttpResponseMessage resp = await client.GetAsync("api/Student");
            if (resp.IsSuccessStatusCode)
            {
                var result = resp.Content.ReadAsStringAsync().Result;
                //student = jsonConvert.DeserializeObject<List<Student>>(result);
                stud = JsonConvert.DeserializeObject<Student>(result);
            }
            return View(stud);
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
