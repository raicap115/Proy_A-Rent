using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proy_A_Rent.Models
{
    
    public class Usuario
    {
        public int id { get; set; }
    
        [Required]
        [Display(Name="Nombre completo")]
        public string nombre { get; set; }

        [Required]
        [Display(Name="Apellido completo")]
        public string apellido { get; set; }
    
        [Required]
        [Display(Name="Género")]
        public char genero { get; set; }

        [Required]
        [Display(Name="Ingrese número de DNI")]
        public string dni { get; set; }
    
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Ingrese número de celular")]
        public string celular { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Ingrese dirección de correo electrónico")]
        public string email { get; set; }
    
        [Required]
        [Display(Name="Ingrese una nueva contraseña")]
        public string password { get; set; }
    }
}