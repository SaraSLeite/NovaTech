using Microsoft.EntityFrameworkCore;
using NovaTech.Models;

namespace NovaTech.Data;

public class AppDbContext : DbContext
{

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Produtos> Produtos { get; set; }
	public DbSet<Categorias> Categorias { get; set; }



	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
	}
	
}