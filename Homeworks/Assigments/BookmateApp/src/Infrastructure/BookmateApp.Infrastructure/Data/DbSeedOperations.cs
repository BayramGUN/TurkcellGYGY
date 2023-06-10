using BookmateApp.Entities;

namespace BookmateApp.Infrastructure.Data;

public static class DbSeedOperations
{
    public static void SeedDatabase(BookmateAppDbContext dbContext)
    {
        seedBookIfNotExist(dbContext);
        seedAuthorIfNotExist(dbContext);
        seedGenreIfNotExist(dbContext);
    }

    private static void seedGenreIfNotExist(BookmateAppDbContext dbContext)
    {
        if(!dbContext.Genres!.Any())
        {
            var genres = new List<Genre> {
                new() { 
                    Id = new Guid("b649bcfa-914f-45cf-96ee-99817ba0dc1e"),
                    Name = "Şiir Kitapları"
                }
            };
            dbContext.Genres!.AddRange(genres);
            dbContext.SaveChanges();
        }
    }

    private static void seedAuthorIfNotExist(BookmateAppDbContext dbContext)
    {
        if(!dbContext.Authors!.Any())
        {
            var authors = new List<Author> {
              new() { 
                        Id = new Guid("bd01c4b4-2bbd-43f1-a1e7-08f661246e9a"),
                        Firstname = "Attilâ",
                        Lastname = "İlhan",
                        Info = "Sisli serüvenlerin kaptanı..."
                    }  
            };
            dbContext.Authors!.AddRange(authors);
            dbContext.SaveChanges();
        }
    }

    private static void seedBookIfNotExist(BookmateAppDbContext dbContext)
    {
        if(!dbContext.Books!.Any())
        {
            var books = new List<Book> {
              new() { 
                    Id = new Guid("c1fdd97a-767e-4396-bedf-5ff4e2e73805"),
                    Title = "Bıçağın Ucu",
                    AuthorId = new Guid("bd01c4b4-2bbd-43f1-a1e7-08f661246e9a"),
                    IsRead = true,
                    Description = "Bıçağın Ucu, Attilâ İlhan'ın Aynanın İçindekiler serisinin ilk yayınlanan romanıdır.",
                    PublishDate = DateTime.Parse("01-01-1973"),
                    CoverImageUrl = "https://upload.wikimedia.org/wikipedia/tr/d/df/Bicakucu.jpg",
                    GenreId = new Guid("b649bcfa-914f-45cf-96ee-99817ba0dc1e"),
                    Rate = 10
                }  
            };
            dbContext.Books!.AddRange(books);
            dbContext.SaveChanges();
        }
    }
}