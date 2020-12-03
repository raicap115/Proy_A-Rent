using Microsoft.EntityFrameworkCore;
using Proy_A_Rent.Models;

namespace Proy_A_Rent.Data
{
    public class ARentContext : DbContext
    {

        public DbSet<Auto> Autos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Bookings> Bookings { get; set; }

        public ARentContext(DbContextOptions dco) : base(dco) {

        }
    }
}