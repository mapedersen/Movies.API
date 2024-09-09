using Movies.API.Models.MovieDtos;

namespace Movies.API.Services
{
    public interface IMovieService
    {
        IEnumerable<MovieDto> GetAllMovies();
        MovieDto? GetMovieById(int id);
        MovieDto AddMovie(MovieForCreationDto movieForCreationDto);
        MovieDto? UpdateMovie(int id, MovieForUpdateDto movieForUpdateDto);
    }
}
