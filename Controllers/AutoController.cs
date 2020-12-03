using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proy_A_Rent.Models;

namespace Proy_A_Rent.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult MercedesBenz()
        {
            return View();
        }

        public IActionResult BMW()
        {
            return View();
        }
        public IActionResult Bentley()
        {
            return View();
        }
        public IActionResult Porsche()
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