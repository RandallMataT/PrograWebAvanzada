namespace practica2.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Categoria> Categoria { get; set; }
    }
}
