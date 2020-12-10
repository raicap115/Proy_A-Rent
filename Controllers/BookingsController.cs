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
    public class BookingsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext db)
        {
            _context=db;
        }

       public IActionResult Index()
       {
           return View();
       }

       public IActionResult Disponibilidad()
       {
           return View();
       }

       [HttpPost]
        public IActionResult Consultar(Bookings objBookings)
        {
            if (ModelState.IsValid) {

                _context.Add(objBookings);
                _context.SaveChanges();

                // Guardar en BD
                return RedirectToAction("RegistroConfirmacion");
            }

            return View("SignUp",objBookings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}