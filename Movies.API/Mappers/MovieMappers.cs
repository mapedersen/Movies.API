using Movies.API.Models.Entities;
using Movies.API.Models.MovieDtos;

namespace Movies.API.Mappers
{
    public static class MovieMappers
    {
        public static MovieDto ToDto(this Movie movie)
        {
            return new MovieDto(
                Id: movie.MovieId,
                Title: movie.Title,
                Rating: movie.Rating,
                ReleaseDate: movie.ReleaseDate,
                Description: movie.Description);
        }
        public static IEnumerable<MovieDto> ToDto(this IEnumerable<Movie> movies)
        {
            return movies.Select(movie => movie.ToDto());
        }

        public static void UpdateMovieFromDto(this Movie movie, MovieForUpdateDto dto)
        {
            if (!string.IsNullOrEmpty(dto.Title))
            {
                movie.Title = dto.Title;
            }

            if (dto.Rating.HasValue)
            {
                movie.Rating = dto.Rating.Value;
            }

            if (dto.ReleaseDate.HasValue)
            {
                movie.ReleaseDate = dto.ReleaseDate.Value;
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                movie.Description = dto.Description;
            }

            if (dto.DirectorId.HasValue)
            {
                movie.DirectorId = dto.DirectorId.Value;
            }
        }
    }
}
