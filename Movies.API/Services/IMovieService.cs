using Movies.API.Models.Dtos;

namespace Movies.API.Services
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetAllMovies();
        MovieDto GetMovieById(int id);
    }
}
