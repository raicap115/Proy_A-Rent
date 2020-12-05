using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proy_A_Rent.Models
{
    [Table("t_bookings)")]
    public class Bookings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }
        [Column("modelo")]
        public string modelo { get; set; }
        [Column("fecha_rec")]
        public string fecha_rec { get; set; }
        [Column("fecha_dev")]
        public string fecha_dev { get; set; }
        [Column("id_usuario")]
        public string id_usuario { get; set; }

    }
}