using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proy_A_Rent.Models
{
    [Table("t_orden_detail")]
    public class Bookings
    {
        [Display(Name="Id")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name="Modelo")]
        [Column("modelo")]
        public string modelo { get; set; }

        [Display(Name="Fecha_rec")]
        [Column("fecha_rec")]
        public string fecha_rec { get; set; }

        [Display(Name="Fecha_dev")]
        [Column("fecha_dev")]
        public string fecha_dev { get; set; }

        [Display(Name="id_usuario")]
        [Column("id_usuario")]
        public string id_usuario { get; set; }

    }
}