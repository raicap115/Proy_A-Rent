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
    public class CarroController : Controller
    {

        private readonly WebAppContext _context;

        public CarroController(WebAppContext context)
        {
            _context = context;
        }    



        public IActionResult Insertar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insertar(MB c)
        {
            if (ModelState.IsValid) {

                _context.Add(c);
                _context.SaveChanges();

                // Guardar en BD
                return RedirectToAction("Index");
            }

            return View(c);
        }


        public IActionResult MB()
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
