using System.ComponentModel.DataAnnotations;

namespace FidelitasComunica.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
    }
}
