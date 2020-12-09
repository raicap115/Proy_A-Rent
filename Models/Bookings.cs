using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proy_A_Rent.Models
{
    [Table("t_orden_detail")]
    public class Bookings
    {
<<<<<<< HEAD

        
        public int id { get; set; }
    
        public Auto modelo { get; set; }
    
=======
        [Display(Name="Id")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name="Modelo")]
        [Column("modelo")]
        public string modelo { get; set; }

        [Display(Name="Fecha_rec")]
        [Column("fecha_rec")]
>>>>>>> 140952ab8981194b92c21149a77e99413c7559ea
        public string fecha_rec { get; set; }

        [Display(Name="Fecha_dev")]
        [Column("fecha_dev")]
        public string fecha_dev { get; set; }
<<<<<<< HEAD
    
        public Usuario id_usuario { get; set; }
=======

        [Display(Name="id_usuario")]
        [Column("id_usuario")]
        public string id_usuario { get; set; }
>>>>>>> 140952ab8981194b92c21149a77e99413c7559ea

    }
}