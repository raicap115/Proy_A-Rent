using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proy_A_Rent.Models;
using Proy_A_Rent.Data;

namespace Proy_A_Rent.Controllers
{
    public class AutoController : Controller
    {

        private readonly ApplicationDbContext _context;

        public AutoController(ApplicationDbContext db){
            _context=db;
        }

        public IActionResult MercedesBenz()
        {
            var lista=_context.Autos.ToList();
            return View(lista);
        }

        public IActionResult BMW()
        {
            var lista=_context.Autos.ToList();
            return View(lista);
        }
        public IActionResult Bentley()
        {
            var lista=_context.Autos.ToList();
            return View(lista);
        }
        public IActionResult Porsche()
        {
            var lista=_context.Autos.ToList();
            return View(lista);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}