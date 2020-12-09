using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proy_A_Rent.Models;
using Proy_A_Rent.Data;
using Microsoft.AspNetCore.Identity;

namespace Proy_A_Rent.Controllers
{
    public class BookingController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public BookingController(ApplicationDbContext db){
            _context=db;
        }

        public BookingController(ILogger<HomeController> logger,
            ApplicationDbContext context, 
            UserManager<IdentityUser> userManager)
            {
                _logger=logger;
                _context=context;
                _userManager=userManager;
            }
        public IActionResult AddItem(int? id)
        {
            var auto = _context.Autos.Find(id);
            var Bookings = Bookings();
            Bookings.modelo=auto.modelo;
            Bookings.id=auto.id;
            var name= _userManager.GetUserName(User);
            Bookings.id_usuario=name;

            _context.Add(Bookings);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
}