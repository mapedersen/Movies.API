using Movies.API.Models.Entities;
using Movies.API.Models.MovieDtos;

namespace Movies.API.Services
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetAllMovies();
        MovieDto? GetMovieById(int id);
        Movie AddMovie(MovieForCreationDto movieForCreationDto);
    }
}
