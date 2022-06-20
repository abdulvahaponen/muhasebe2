using Microsoft.EntityFrameworkCore;

namespace Muhasebe.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SUPERCHARGER;database=muhasebeApp;integrated security=true;");
        }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Stok> Stoks { get; set; }
    }
}
