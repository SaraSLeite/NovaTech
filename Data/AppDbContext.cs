
			using Microsoft.AspNetCore.Identity;
			using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
			using Microsoft.EntityFrameworkCore;
			using NovaTech.Models;

			namespace NovaTech.Data;

			public class AppDbContext : IdentityDbContext
			{

				public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
				{
				}

				public DbSet<Pokemon> Produtos { get; set; }
	
				protected override void OnModelCreating(ModelBuilder builder)
				{
					base.OnModelCreating(builder);
				}
			}