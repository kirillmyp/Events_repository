using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Events_Repository.Models;
using Events_Repository.Tools;
using Microsoft.Extensions.Configuration;

namespace Events_Repository.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new DBManagersCreator().CreateDefaultConnection())
            {
                var select = "select max(employeeid) from employees";
                var result = db.ScalarRequest(select, null).ToString();
                ViewBag.MaxEmplId = result;
            }
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
