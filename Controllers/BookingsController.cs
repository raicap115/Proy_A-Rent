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
           if (User.Identity.IsAuthenticated){
            Usuario objUsuario=new Usuario();
            objUsuario= _context.Usuarios.Where(m => m.email == User.Identity.Name).FirstOrDefault();
            var consulta=_context.Bookings.Where(m => m.id_usuario == objUsuario.id).FirstOrDefault();
                if(consulta!=null){
                    var lista = _context.Bookings.Where(m => m.id_usuario == objUsuario.id).ToList();
                    return View(lista);
                }            
            }
            return View();

            //var lista=_context.Bookings.ToList().Where();
            //return View(lista);
       }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
