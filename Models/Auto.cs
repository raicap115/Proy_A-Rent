using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Proy_A_Rent.Models
{
    
    public class Auto
    {
        
        public int id { get; set; }

        
        public string marca { get; set; }

        [Display(Name="Modelo del Auto")]
        public string modelo { get; set; }

        
        public int cant { get; set; }
    }
}