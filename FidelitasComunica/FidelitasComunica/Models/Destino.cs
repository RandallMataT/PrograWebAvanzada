using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FidelitasComunica.Models
{
    public class Destino
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [Required]
        [DisplayName("País")]
        public string pais { get; set; }

        [Required]
        [DisplayName("Ciudad")]
        public string ciudad { get; set; }

        [Required]
        [DisplayName("Descripción")]
        public string descripcion { get; set; }

        [Required]
        [DisplayName("Clima")]
        public string clima { get; set; }

        [Required]
        [DisplayName("Atracciones")]
        public string atracciones { get; set; }

        [Required]
        [DisplayName("Idioma principal")]
        public string idioma_principal { get; set; }

        [Required]
        [DisplayName("Moneda")]
        public string moneda { get; set; }

        [DisplayName("Imagen")]
        public string imagen { get; set; }
    }
}
