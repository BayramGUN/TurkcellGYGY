using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;

namespace Movies.Application;
public interface IMovieService
{
    Task<int> CreateNewMovie(CreateNewMovieRequest createNewMovie); 
    Task UpdateMovie(UpdateMovieRequest updateMovie); 
    Task<IEnumerable<MovieListResponse>> GetAllMovies();
    Task UpdateMoviesPlayer(UpdateMoviesPlayerRequest updateMoviesPlayerRequest, int movieId, int playerId);
}