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

        public DbSet<FidelitasComunica.Models.Paquete>? Paquetes { get; set; }
    }
}
