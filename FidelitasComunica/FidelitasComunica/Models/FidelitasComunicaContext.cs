using Microsoft.EntityFrameworkCore;
using FidelitasComunica.Models;

namespace FidelitasComunica.Models
{
    public class FidelitasComunicaContext : DbContext
    {
        public FidelitasComunicaContext(DbContextOptions<FidelitasComunicaContext> opciones) 
            :base(opciones)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Paquete> Paquete { get; set; }

        public DbSet<Destino> Destino { get; set; }
    }
}
