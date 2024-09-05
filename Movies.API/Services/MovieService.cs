using Movies.API.Data;
using Movies.API.Mappers;
using Movies.API.Models.Dtos;

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
            return MovieMappers.MapCollectionToDto(movies);
        }

        public MovieDto GetMovieById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieId == id);

            if (movie == null)
            {
                return null;
            }
            return MovieMappers.MapSingleToDto(movie);
        }
    }
}
