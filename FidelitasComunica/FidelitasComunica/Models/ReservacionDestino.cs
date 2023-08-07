using System.ComponentModel;

namespace FidelitasComunica.Models
{
    public class ReservacionDestino
    {
        public int ID { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Apellidos")]
        public string apellidos { get; set; }

        [DisplayName("Correo")]
        public string correo { get; set; }

        [DisplayName("Nombre de Destino")]
        public string? nombre_destino { get; set; }
    }
}
