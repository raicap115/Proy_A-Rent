using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proy_A_Rent.Models
{
    
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
    
        [Required(ErrorMessage="Por favor, Ingrese nombre completo")]
        [Display(Name="Nombres")]
        public string nombre { get; set; }

        [Required(ErrorMessage="Por favor, Ingrese apellidos completos")]
        [Display(Name="Apellidos")]
        public string apellido { get; set; }
           
        [Required(ErrorMessage="Ingrese un celular de contacto")]
        [Display(Name="Ingrese número de celular")]
        public string celular { get; set; }

        [Required(ErrorMessage="Ingrese un email")]
        [Display(Name="Correo Electrónico")]
        public string email { get; set; }
    
        [Required(ErrorMessage="Ingrese una contraseña")]
        [Display(Name="Contraseña")]
        public string password { get; set; }        

        [Required(ErrorMessage="Ingrese un número de documento")]
        [Display(Name="Documento de identidad")]
        [StringLength(8, MinimumLength=8, ErrorMessage="Debe ingresar un número minimo de 8 dígitos")]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessage = "Ingresa un numero valido")]

        public string dni { get; set; }
    }
}