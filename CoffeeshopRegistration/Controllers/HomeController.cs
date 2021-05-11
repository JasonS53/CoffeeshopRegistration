using CoffeeshopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeshopRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Result(User user)
        {
            //Put user info in cookie
            HttpContext.Response.Cookies.Append("FirstName", user.FirstName);
            HttpContext.Response.Cookies.Append("LastName", user.LastName);
            HttpContext.Response.Cookies.Append("Email", user.Email);
            HttpContext.Response.Cookies.Append("Password", user.Password);
            HttpContext.Response.Cookies.Append("CoffeeTemp", user.CoffeeTemp);
            HttpContext.Response.Cookies.Append("CoffeeType", user.CoffeeType);
            HttpContext.Response.Cookies.Append("TeaTemp", user.TeaTemp);
            HttpContext.Response.Cookies.Append("TeaType", user.TeaType);
            
            ViewData["FirstName"] = user.FirstName;
            return View();
        }

        public IActionResult CustomerInfo()
        {
            //take user info out of cookie
            ViewData["FirstName"] = HttpContext.Request.Cookies["FirstName"];
            ViewData["LastName"] = HttpContext.Request.Cookies["LastName"];
            ViewData["Email"] = HttpContext.Request.Cookies["Email"];
            ViewData["Password"] = HttpContext.Request.Cookies["Password"];
            ViewData["CoffeeTemp"] = HttpContext.Request.Cookies["CoffeeTemp"];
            ViewData["CoffeeType"] = HttpContext.Request.Cookies["CoffeeType"];
            ViewData["TeaTemp"] = HttpContext.Request.Cookies["TeaTemp"];
            ViewData["TeaType"] = HttpContext.Request.Cookies["TeaType"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
