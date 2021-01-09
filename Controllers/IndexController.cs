using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proy_A_Rent.Data;
using Proy_A_Rent.Models;

namespace Proy_A_Rent.Controllers
{
    public class IndexController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _um;

        public IndexController(UserManager<IdentityUser> um, ApplicationDbContext db){
            _context=db;
            _um = um;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated){
            Usuario objUsuario=new Usuario();
            objUsuario= _context.Usuarios.Where(m => m.email == User.Identity.Name).FirstOrDefault();
            var nomUsu=objUsuario.nombre;
            objUsuario.nom_usuario=nomUsu;

            return View("Index",objUsuario);
            }
            return View();
        }
       

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Nosotros()
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
