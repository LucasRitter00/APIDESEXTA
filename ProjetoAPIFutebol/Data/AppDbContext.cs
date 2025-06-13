using Microsoft.EntityFrameworkCore;
using ProjetoAPIFutebol.Models;

namespace ProjetoAPIFutebol.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Jogador> Jogadores { get; set; } = null!;
    }
}
