using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;

namespace Movies.Application;
public class MovieService : IMovieService
{
    private readonly IMovieRepository movieRepository;
    public MovieService(IMovieRepository movieRepository)
    {
        this.movieRepository = movieRepository;
    }
    public async Task<int> CreateNewMovie(CreateNewMovieRequest createNewMovie)
    {
        var movie = new Movie {
            DirectorId = createNewMovie.DirectorId,
            Duration = createNewMovie.Duration,
            Name = createNewMovie.Name,
            Poster = createNewMovie.Poster,
            PublishDate = createNewMovie.PublishDate,
            Rating = createNewMovie.Rating
        };
        await movieRepository.CreateAsync(movie);
        return movie.Id;
    }

    public async Task<IEnumerable<MovieListResponse>> GetAllMovies()
    {
        var movies = await movieRepository.GetAllAsync();
        var response = movies.Select(movie => new MovieListResponse {
            Duration = movie.Duration,
            Name = movie.Name,
            Id = movie.Id,
            PublishDate = movie.PublishDate,
            Rating = movie.Rating,
            DirectoryName = $"{movie.Director?.Name} {movie.Director?.LastName}",
            Players = string.Join(",", 
                            movie.Players.Select(moviePlayer => new
                            {
                                FullName = $"{moviePlayer.Player.Name} {moviePlayer.Player.LastName}"
                            }))
        });
        return response;
    }

    public Task UpdateMovie(UpdateMovieRequest updateMovie)
    {
        throw new NotImplementedException();
    }
    public async Task UpdateMoviesPlayer(UpdateMoviesPlayerRequest updateMoviesPlayerRequest, int movieId, int playerId)
    {
        var movie = movieRepository.GetByIdAsync(movieId);
        await movieRepository.UpdateAsync(updateMoviesPlayerRequest);
    }
}