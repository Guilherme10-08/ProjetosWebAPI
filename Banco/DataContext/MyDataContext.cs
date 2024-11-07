using Banco.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco.DataContext
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions options) : base(options) { }

        public DbSet<AberturaConta> AberturaContas {get; set;}
    }
}
