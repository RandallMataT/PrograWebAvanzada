namespace FidelitasComunica.Models
{
    public class ReservacionPaquete
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int? ID_PAQUETE { get; set; }
        public string? tipo_paquete { get; set; }
    }
}
