using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Proy_A-Rent.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppContext.Models.Formulario> Contactos { get; set; }
    }
}