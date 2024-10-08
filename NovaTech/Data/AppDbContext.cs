using Microsoft.EntityFrameworkCore;
using NovaTech.Models;

namespace NovaTech.Data;

public class AppDbContext : DbContext
{

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Produto> Produtos { get; set; }
	public DbSet<Categoria> Categorias { get; set; }



	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
	}
	
}