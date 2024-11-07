using Farmacia.Models;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.DataContext
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions options):base(options){}
        public DbSet<Comprimido> Comprimidos { get; set; }
        public DbSet<Xarope> Xaropes { get; set; }
        public DbSet<Soro> Soros { get; set; }
        public DbSet<Ampola> Ampolas { get; set; }
        public DbSet<Vitamina> Vitaminas { get; set; }
        
    }
}
