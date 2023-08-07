namespace FidelitasComunica.Models
{
    public class ReservacionDestino
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int? ID_DESTINO { get; set; }
        public string? nombre_destino { get; set; }
    }
}
