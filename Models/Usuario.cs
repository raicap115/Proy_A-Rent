namespace Proy_A_Rent.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public char genero { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}