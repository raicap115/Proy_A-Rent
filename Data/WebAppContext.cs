using Proy_A_Rent.Models;
using Microsoft.EntityFrameworkCore;

namespace Proy_A_Rent.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<MB> Carros { get; set; }

        public WebAppContext(DbContextOptions dco) : base(dco) {

        }
    }
}