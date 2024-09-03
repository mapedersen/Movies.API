using Movies.API.Models.DTO;

namespace Movies.API.Services
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetAllMovies();
    }
}
