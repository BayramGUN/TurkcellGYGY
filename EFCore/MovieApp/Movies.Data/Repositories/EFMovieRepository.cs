using Microsoft.EntityFrameworkCore;
using Movies.Entities;

namespace Movies.Data.Repositories;

public class EFMovieRepository : IMovieRepository
{
    private readonly MoviesDbContext moviesDbContext;

    public EFMovieRepository(MoviesDbContext moviesDbContext)
    {
        this.moviesDbContext = moviesDbContext;
    }

    public void Create(Movie entity)
    {
        moviesDbContext.Movies.Add(entity);
        moviesDbContext.SaveChanges();
    }
    public async Task CreateAsync(Movie entity)
    {
        await moviesDbContext.Movies.AddAsync(entity);
        await moviesDbContext.SaveChangesAsync(); //Pertsistance API
    }

    public async Task DeleteAsync(int id)
    {
        var movie = await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
        if(movie is not null)
            moviesDbContext.Movies.Remove(movie);
        await moviesDbContext.SaveChangesAsync();
    }

    public async Task<ICollection<Movie>> GetAllAsync()
    {
        return await moviesDbContext.Movies.AsNoTracking().ToListAsync();
    }

    public async Task<Movie?> GetByIdAsync(int id)
    {
        return await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<ICollection<Movie>> SearchMoviesByTitle(string title)
    {
        return await moviesDbContext.Movies.AsNoTracking()
                                            .Where(movie => movie.Name.Contains(title))
                                            .ToListAsync();
    }

    public async Task UpdateAsync(Movie entity)
    {
        // Task of the service. 
        /*var movie = await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(m => m.Id == entity.Id);
        if (movie is not null) */ 
        moviesDbContext.Movies.Update(entity);
        await moviesDbContext.SaveChangesAsync();
    }
}