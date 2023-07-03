using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FidelitasComunica.Models
{
    public class Paquete
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [Required]
        [DisplayName("Destino")]
        public string destino { get; set; }

        [Required]
        [DisplayName("Duración (días)")]
        public int duracion_dias { get; set; }

        [Required]
        [DisplayName("Precio")]
        public decimal precio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de inicio")]
        public DateTime fecha_inicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de fin")]
        public DateTime fecha_fin { get; set; }

        [Required]
        [DisplayName("Descripción")]
        public string descripcion { get; set; }

        [Required]
        [DisplayName("Cantidad de personas")]
        public int cantidad_personas { get; set; }
    }
}
