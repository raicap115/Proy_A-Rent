using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proy_A_Rent.Models
{
    
    public class Bookings
    {
        public int id { get; set; }
    
        public string modelo { get; set; }
    
        public string fecha_rec { get; set; }
    
        public string fecha_dev { get; set; }
    
        public string id_usuario { get; set; }

    }
}