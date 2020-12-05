using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proy_A_Rent.Models
{
    [Table("t_auto)")]
    public class Auto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Column("marca")]
        public string marca { get; set; }

        [Column("modelo")]
        public string modelo { get; set; }

        [Column("cant")]
        public int cant { get; set; }
    }
}