using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Infrastructures;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[LoginFilter("Admin")]
        //[LoginFilter("Developer")]
        [LoginFilter("User")]
        public IActionResult Index()
        {
            return View();
        }

        //LoginFilter attribute'umuzu admin olarak ve developer olarak ayarladigimizda direkt olarak ana sayfa yonlendirmesi yapti
        //attribute'u User olarak ayarladigimizdaysa bizi dogrudan Privacy sayfasina yonlendirdi.

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
