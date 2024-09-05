using Movies.API.Models.Dtos;
using Movies.API.Models.Entities;

namespace Movies.API.Mappers
{
    public static class MovieMappers
    {
        public static IEnumerable<MovieDto> MapCollectionToDto(IEnumerable<Movie> movies)
        {
            return movies.Select(movie => new MovieDto(
                Id: movie.MovieId,
                Title: movie.Title,
                Rating: movie.Rating,
                ReleaseDate: movie.ReleaseDate,
                Description: movie.Description));
        }

        public static MovieDto MapSingleToDto(Movie movie)
        {
            return new MovieDto(
                Id: movie.MovieId,
                Title: movie.Title,
                Rating: movie.Rating,
                ReleaseDate: movie.ReleaseDate,
                Description: movie.Description);
        }

        //public static Movie ToEntity(this MovieForCreationDto dto)
        //{
        //    return new Movie
        //    {
        //        Title = dto.Title,
        //        Rating = dto.Rating,
        //        ReleaseDate = dto.ReleaseDate,
        //        Description = dto.Description,
        //        DirectorId = dto.DirectorId,
        //    };
        //}
    }
}
