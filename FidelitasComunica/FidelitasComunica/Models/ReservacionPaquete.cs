using System.ComponentModel;

namespace FidelitasComunica.Models
{
    public class ReservacionPaquete
    {
        public int ID { get; set; }

        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Apellidos")]
        public string apellidos { get; set; }

        [DisplayName("Correo")]
        public string correo { get; set; }

        [DisplayName("Nombre de Paquete")]
        public string? nombre_paquete { get; set; }
    }
}
