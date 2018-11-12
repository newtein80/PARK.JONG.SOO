using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PARK.JONG.SOO.Data;
using PARK.JONG.SOO.Models;
using PARK.JONG.SOO.Models.ApplicationModel;

namespace PARK.JONG.SOO.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _applicationDbContext;

        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserList()
        {
            return View(_applicationDbContext.Users.ToList());
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            //return View(_applicationDbContext.Users.ToList());
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
