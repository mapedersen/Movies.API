namespace Movies.API.Models.Dtos
{
    public record MovieDto(
        string Title,
        long Rating,
        DateTime ReleaseDate,
        string Description
    );
}
