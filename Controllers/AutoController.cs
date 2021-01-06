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

        public IActionResult Consulta(int id){
            var consulta = _context.Autos.Where(m => m.id == id).FirstOrDefault();             
            return PartialView("Consulta",consulta);
        }

        [HttpPost]
        public IActionResult Consultar(int id)
        {
            Auto objAuto=new Auto();
            var cantidad = objAuto.cant;
            
            var rpt= "Unavailable";    
            
            if (cantidad>0) {                
                rpt = "Available";
                cantidad--;                
            }

            objAuto.respuesta = rpt;
            return PartialView("Consulta",rpt);
        }



        [HttpPost]
        public IActionResult Reserva(string mod, string fec_rec, string fec_dev, int id_usu)
        {
            var objBooking= new Bookings();
            objBooking.modelo_auto=mod;
            objBooking.fecha_rec=fec_rec;
            objBooking.fecha_dev=fec_dev;
            objBooking.id_usuario=id_usu;

            _context.Bookings.Add(objBooking);
            _context.SaveChanges();
            
            return RedirectToAction("Index","Bookings");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}