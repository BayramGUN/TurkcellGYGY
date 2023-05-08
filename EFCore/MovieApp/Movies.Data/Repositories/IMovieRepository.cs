using Movies.Entities;
namespace Movies.Data.Repositories;

public interface IMovieRepository : IRepository<Movie>
{
    Task<ICollection<Movie>> SearchMoviesByTitle(string title);
}