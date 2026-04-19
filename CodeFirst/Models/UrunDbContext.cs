using Microsoft.EntityFrameworkCore;
namespace CodeFirst.Models
{
    public class UrunDbContext : DbContext
    {
        public UrunDbContext(DbContextOptions<UrunDbContext> options) : base(options)
        {
        }
        public DbSet<Urun> Uruns { get; set; }
    }
}
