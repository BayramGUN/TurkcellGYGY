using EFCoreBasics.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasics.Context;

class AppDbContext : DbContext
{
    private const string connecitonString = "Server=localhost,1433;Database=EFCoreDb;User=sa;Password=yourStrong(!)Password;TrustServerCertificate=True;Trusted_Connection=False;Encrypt=False;Trusted_Connection=False;MultipleActiveResultSets=True";

    /* public AppDbContext()
    {
        
    } */
   /*  public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    */
    public DbSet<Book> Books { get; set; }  = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    //public DbSet<Author>? Authors { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connecitonString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Model sınıflarınız (POCO) db'ye aktarılırken, nasıl bir ilişki kurulacak?
        modelBuilder.Entity<Book>().Property(book => book.Title).IsRequired()
                                                                .HasMaxLength(250);
        modelBuilder.Entity<Book>().Property(book => book.Description).HasMaxLength(750);
        modelBuilder.Entity<Review>().HasOne(review => review.Book)
                                        .WithMany(book => book.Reviews)
                                        .HasForeignKey(review => review.BookId)
                                        .OnDelete( DeleteBehavior.Restrict );
        
    }
}