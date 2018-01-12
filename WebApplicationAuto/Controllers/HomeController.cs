using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAuto.Models;
using WebApplicationAuto.Services;

namespace WebApplicationAuto.Controllers
{
    public class HomeController : Controller
    {
        IEmailSender ml;

        public HomeController(IEmailSender ml)
        {
            this.ml = ml;    
        }
        public IActionResult Index()
        {
            ViewBag.textEmail = ml.getText();
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
