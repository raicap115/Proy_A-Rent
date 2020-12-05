using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proy_A_Rent.Models
{
    [Table("t_usuario")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }
        [Column("nombre")]
        public string nombre { get; set; }
        [Column("apellido")]
        public string apellido { get; set; }
        [Column("genero")]
        public char genero { get; set; }
        [Column("celular")]
        public string celular { get; set; }
        [Column("email")]
        public string email { get; set; }
        [Column("password")]
        public string password { get; set; }
    }
}