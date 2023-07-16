namespace practica2.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ProductoID { get; set; }
        public Producto? Producto { get; set; }
    }
}
