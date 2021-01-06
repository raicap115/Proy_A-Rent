using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proy_A_Rent.Models
{
    
    public class Bookings
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
    
        public string modelo_auto { get; set; }
    
        [Display(Name="Fecha de recogida")]
        public string fecha_rec { get; set; }
    
        [Display(Name="Fecha de devolución")]
        public string fecha_dev { get; set; }
    
        public int id_usuario { get; set; }

        public int cant_auto {get;set;}

    }
}