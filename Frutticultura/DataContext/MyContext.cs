using Frutticultura.Models;
using Microsoft.EntityFrameworkCore;

namespace Frutticultura.DataContext
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions<MyContext> options):base(options){}			
		public DbSet<Frutta> Fruttas { get; set; }
		public DbSet<Arvore> Arvores { get; set; }

	}
}
