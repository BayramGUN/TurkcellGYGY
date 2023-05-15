using Microsoft.EntityFrameworkCore;
using Movies.Entities;

namespace Movies.Data.Data;

public class MoviesDbContext : DbContext
{   
    private const string connecitonString = "Server=localhost,1433;Database=MovieDb;User=sa;Password=yourStrong(!)Password;TrustServerCertificate=True;Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=True";

    public DbSet<Movie> Movies { get; set; } = null!;
    public DbSet<Director> Directors { get; set; } = null!;
    public DbSet<Player> Players { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().Property(m => m.Name)
                                    .IsRequired()
                                    .HasMaxLength(300);

        modelBuilder.Entity<Movie>().HasOne(m => m.Director)
                                    .WithMany(d => d.Movies)
                                    .HasForeignKey(m => m.DirectorId)
                                    .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<MoviesPlayer>().HasKey("MovieId", "PlayerId");

        modelBuilder.Entity<Movie>().HasMany(m => m.Players)
                                    .WithOne(mp => mp.Movie)
                                    .HasForeignKey(mp => mp.MovieId)
                                    .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Player>().HasMany(p => p.Movies)
                                     .WithOne(mp => mp.Player)
                                     .HasForeignKey(mp => mp.PlayerId)
                                     .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Director>().HasData(new Director { Id = 1, Name = "Nuri Bilge", LastName = "Ceylan" });
        modelBuilder.Entity<Player>().HasData(new Player { Id = 1, Name = "Doğu", LastName = "Demirkol" });
        modelBuilder.Entity<Movie>().HasData(new Movie { Id = 1, Name = "Ahlat Ağacı", DirectorId = 1, Rating = 8.7 });
        modelBuilder.Entity<MoviesPlayer>().HasData(new MoviesPlayer {MovieId = 1, PlayerId = 1, Role = "Sinan Karasu (Atanmamış Coğrafya Öğretmeni)"});
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connecitonString);
    }
    
}