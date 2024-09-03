namespace Movies.API.Models.DTO
{
    public record MovieDto(
        string Title,
        long Rating,
        DateTime ReleaseDate,
        string Description
    );
}
