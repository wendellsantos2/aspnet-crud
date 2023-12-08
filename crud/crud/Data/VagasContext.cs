using Microsoft.EntityFrameworkCore;
using crud.Models; // Este namespace deve conter a definição do seu modelo 'Vaga'

namespace crud
{
    public class VagasContext : DbContext
    {
        public VagasContext(DbContextOptions<VagasContext> options) : base(options)
        {
        }

        public DbSet<Vaga> Vagas { get; set; } // DbSet para o modelo Vaga

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais para o modelo Vaga (se necessário)
            base.OnModelCreating(modelBuilder);
        }

 
    }
}
