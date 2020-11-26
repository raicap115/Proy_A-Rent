using System.ComponentModel.DataAnnotations;

namespace Proy_A_Rent.Models
{
    public class BMW
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Mensaje { get; set; }
    }
}