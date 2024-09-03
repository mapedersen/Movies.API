using Movies.API.Data;
using Movies.API.Models.DTO;

namespace Movies.API.Services
{
    public class MovieService : IMovieService
    {
        private readonly MoviesContext _context;

        public MovieService(MoviesContext context)
        {
            _context = context;
        }

        public IEnumerable<MovieDto> GetAllMovies()
        {
            var movies = _context.Movies.ToList();

            var movieDtos = movies.Select(movie => new MovieDto(
                movie.Title,
                movie.Rating,
                movie.ReleaseDate,
                movie.Description
            ));

            return movieDtos;
        }
    }
}
