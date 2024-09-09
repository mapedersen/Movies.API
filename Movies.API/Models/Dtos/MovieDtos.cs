using System.ComponentModel.DataAnnotations;

namespace Movies.API.Models.MovieDtos
{
    public record MovieDto(
        int Id,
        string Title,
        long Rating,
        DateTime ReleaseDate,
        string Description
    );

    public record MovieForCreationDto(
         [Required, MaxLength(100)] string Title,
         [Range(1, 10)] long Rating,
         [Required] DateTime ReleaseDate,
         [MaxLength(500)] string Description,
         [Required] int DirectorId
     );

    public record MovieForUpdateDto(
        string? Title,
        long? Rating,
        DateTime? ReleaseDate,
        string? Description,
        int? DirectorId
    );
}
