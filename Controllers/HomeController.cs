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
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult SingUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SingUp(Usuario u)
        {
            if(ModelState.IsValid){

                _context.Add(u);
                _context.SaveChanges();

                // Guardar en BD
                return RedirectToAction("RegistroConfirmacion");
            }
            return View("Home",u);
                        
        }

        public IActionResult RegistroConfirmacion()
        {
            return View();
        }

        public IActionResult Login()
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
