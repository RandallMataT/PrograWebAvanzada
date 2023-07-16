using Microsoft.EntityFrameworkCore;

namespace practica2.Models
{
    public class practica2Context : DbContext   
    {
        public practica2Context(DbContextOptions<practica2Context> opciones)
            : base(opciones)
        { 
        }

        public DbSet<Producto> Porducto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(Producto =>
            {
                Producto.HasKey(x => x.Id);
                Producto.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
                Producto.Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(300);
            });

            modelBuilder.Entity<Categoria>()
                .HasOne(x => x.Producto)
                .WithMany(c => c.Categoria)
                .HasForeignKey(f => f.ProductoID);
        }
    }
}
