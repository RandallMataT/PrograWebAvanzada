using Microsoft.EntityFrameworkCore;

namespace FidelitasComunica.Models
{
    public class FidelitasComunicaContext : DbContext
    {
        public FidelitasComunicaContext(DbContextOptions<FidelitasComunicaContext> opciones) 
            :base(opciones)
        {
        }

        public DbSet<Usuario> Uusario { get; set; }
    }
}
