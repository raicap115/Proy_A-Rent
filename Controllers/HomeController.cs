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
using Microsoft.AspNetCore.Identity;

namespace Proy_A_Rent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sim;

        public HomeController(ApplicationDbContext context,UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            _context = context;
            _um = um;
            _sim = sim;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Usuario objUsuario)
        {
            if (ModelState.IsValid) {

                _context.Add(objUsuario);
                _context.SaveChanges();

                var correo = objUsuario.email;
                var password =objUsuario.password;

                var user = new IdentityUser();
                user.Email = correo;
                user.UserName = correo;

                var result = _um.CreateAsync(user, password).Result;

                // Guardar en BD
                return RedirectToAction("Login");
            }

            return View("SignUp",objUsuario);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo, string password)
        {
            var result = _sim.PasswordSignInAsync(correo, password, false, false).Result;

            if (result.Succeeded) {
                return RedirectToAction("Index", "Index");
            } 

            ModelState.AddModelError("", " Email y/o contraseña incorrectos");

            return View();
        } 
        public async Task<IActionResult> Logout()
        {
            await _sim.SignOutAsync();

            return RedirectToAction("home", "home");
        } 
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
