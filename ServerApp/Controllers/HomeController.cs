using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerApp.Models;

// 04
using System.Linq;

namespace ServerApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        // 04
        private DataContext context;


        //public HomeController(ILogger<HomeController> logger)
        // 04
        public HomeController(DataContext ctx)
        {
            //_logger = logger;
            // 04
            context = ctx;
        }

        public IActionResult Index()
        {
            //return View();
            //return View("Placeholder");
            return View(context.Products.First()); // 04
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
