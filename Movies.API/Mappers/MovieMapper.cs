using Movies.API.Models.DTO;
using Movies.API.Models.Entities;

namespace Movies.API.Mappers
{
    public static class MovieMappers
    {
        public static IEnumerable<MovieDto> MapCollectionToDto(IEnumerable<Movie> movies)
        {
            return movies.Select(movie => new MovieDto(
                movie.Title,
                movie.Rating,
                movie.ReleaseDate,
                movie.Description));
        }

        public static MovieDto MapSingleToDto(Movie movie)
        {
            return new MovieDto(movie.Title, movie.Rating, movie.ReleaseDate, movie.Description);
        }
    }
}
