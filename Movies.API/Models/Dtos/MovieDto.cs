namespace Movies.API.Models.Dtos
{
    public record MovieDto(
        int Id,
        string Title,
        long Rating,
        DateTime ReleaseDate,
        string Description
    );
}
