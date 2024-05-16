using DatabaseWrapper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWrapper;

public class Repository : DbContext
{
	public DbSet<AppUser> AppUsers { get; set; }
	public Repository()
	{
		AppUsers = Set<AppUser>();
	}
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AuDatabase;Trusted_Connection=True;", b => b.MigrationsAssembly("APIServer"));
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<AppUser>().HasData
		(
			new AppUser { Id = 1, Name = "Billy" }
		);
	}
}
