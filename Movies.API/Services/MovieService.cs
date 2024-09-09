using Movies.API.Data;
using Movies.API.Mappers;
using Movies.API.Models.Entities;
using Movies.API.Models.MovieDtos;

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
            return movies.ToDto();
        }

        public MovieDto? GetMovieById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieId == id);

            if (movie == null)
            {
                return null;
            }
            return movie.ToDto();
        }

        public MovieDto AddMovie(MovieForCreationDto movieForCreationDto)
        {
            var newMovie = new Movie
            {
                Title = movieForCreationDto.Title,
                Rating = movieForCreationDto.Rating,
                ReleaseDate = movieForCreationDto.ReleaseDate,
                Description = movieForCreationDto.Description,
                DirectorId = movieForCreationDto.DirectorId
            };
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
            return newMovie.ToDto();

        }

        public MovieDto? UpdateMovie(int id, MovieForUpdateDto movieForUpdateDto)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieId == id);

            if (movie == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(movieForUpdateDto.Title))
            {
                movie.Title = movieForUpdateDto.Title;
            }

            if (movieForUpdateDto.Rating.HasValue)
            {
                movie.Rating = movieForUpdateDto.Rating.Value;
            }

            if (movieForUpdateDto.ReleaseDate.HasValue)
            {
                movie.ReleaseDate = movieForUpdateDto.ReleaseDate.Value;
            }

            if (!string.IsNullOrEmpty(movieForUpdateDto.Description))
            {
                movie.Description = movieForUpdateDto.Description;
            }

            if (movieForUpdateDto.DirectorId.HasValue)
            {
                movie.DirectorId = movieForUpdateDto.DirectorId.Value;
            }

            _context.SaveChanges();
            return movie.ToDto();
        }
    }
}
