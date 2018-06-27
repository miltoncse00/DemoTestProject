using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Demo.Business;
using Demo.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectBusiness _project;

        public HomeController(IProjectBusiness project)
        {
            _project = project;
        }
        public IActionResult Index()
        {
            return View();
         
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
