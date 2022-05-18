using HealthProfile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HealthProfile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Health model)
        {
            ViewBag.FullName = model.FullName();
            ViewBag.Age = model.Age();
            ViewBag.Gender = model.Gender;
            ViewBag.BMI = model.BMI();
            ViewBag.MaximumHeartRate = model.MaximumHeartRate();
            ViewBag.MinimumTargetHeartRate = model.MinimumTargetHeartRate();
            ViewBag.MaximumTargetHeartRate = model.MaximumTargetHeartRate();


            return View(model);
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
