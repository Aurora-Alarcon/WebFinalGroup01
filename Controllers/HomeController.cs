using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebFinalGroup01.Models;

namespace WebFinalGroup01.Controllers
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

        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult Plan()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

   // capture of signon variables: user & password 
        [HttpPost]
        public ActionResult LoginResults(String user, String password)
        {
            Userlogin user1 = new Userlogin();
            user1.user = user;
            user1.password = password;

  /*go to plan if user & pass are correct */


            if (!String.IsNullOrEmpty(user1.user) && !String.IsNullOrEmpty(user1.password) )
                {
                return View("Plan");
                }
            else
                {
                return View("Homepage");
                }

        }

        /*   validation second page variables  */
        [HttpPost]
        public ActionResult Planvalidation(String from_date, String to_date, String location1, String location2, String nature, String city, String outdoor )
        {
            Planvalidation Plan = new Planvalidation();
            Plan.from_date = from_date;
            Plan.to_date   = to_date;
            Plan.location1 = location1;
            Plan.location2 = location2;
            Plan.nature    = nature;
            Plan.city      = city;
            Plan.outdoor   = outdoor;
           
            /*go to DB to write variables if those are correct ----must go to trending page*/

            if (!String.IsNullOrEmpty(Plan.location1) && !String.IsNullOrEmpty(Plan.location2))
            {
                return View("Plan");
            }
            else
            {
                return View("Plan");
            }

        }

    }
}
