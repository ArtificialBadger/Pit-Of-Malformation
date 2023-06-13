using Microsoft.EntityFrameworkCore;

namespace Lorekeeper.Storage;

public class CharacterContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server=localhost;Database=Tomb;Trusted_Connection=True;TrustServerCertificate=True;");
	}

	public DbSet<Character> Characters { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Character>().ToTable("Characters");
	}
}
