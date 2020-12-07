using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proy_A_Rent.Models;
using Proy_A_Rent.Data;
using Microsoft.EntityFrameworkCore;

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

         public IActionResult Enviar(Usuario objFormulario)
        {
                objFormulario.Respuesta = "HEMOS PROCESADO SU SOLICITUD";
                _context.Add(objFormulario);
                _context.SaveChanges();
                return View("SingUp", objFormulario);
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
