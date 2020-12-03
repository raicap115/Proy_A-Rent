namespace Proy_A_Rent.Models
{
    public class Bookings
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string fecha_rec { get; set; }
        public string fecha_dev { get; set; }
        
        public Usuario idUsuario { get; }

    }
}