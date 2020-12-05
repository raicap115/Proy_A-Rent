using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proy_A_Rent.Models;

namespace Proy_A_Rent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Auto> Autos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Bookings> Bookings { get; set; }


        public ApplicationDbContext(DbContextOptions dco) : base(dco) {

        }
    }
}
