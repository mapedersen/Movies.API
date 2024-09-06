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
