using Microsoft.EntityFrameworkCore;

namespace atividade_veiculos.Services
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options): base(options) 
        { 

        }

        public DbSet<Veiculo> Veiculos { get; set; } = null!;
    }
}
