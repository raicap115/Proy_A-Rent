using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proy_A_Rent.Models
{
    
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
    
        [Required]
        [Display(Name="Nombre completo")]
        public string nombre { get; set; }

        [Required]
        [Display(Name="Apellido completo")]
        public string apellido { get; set; }
    
        [Required]
        [StringLength(9)]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "No es un número de teléfono válido")]
        [Display(Name="Ingrese número de celular")]
        public string celular { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Ingrese dirección de correo electrónico")]
        public string email { get; set; }
    
        [Required]
        [Display(Name="Ingrese una nueva contraseña")]
        public string password { get; set; }        

        [Required]
        [Display(Name="Ingrese número de DNI")]
        public string dni { get; set; }

        [NotMapped]
        public String Respuesta { get; set; }
    }
}