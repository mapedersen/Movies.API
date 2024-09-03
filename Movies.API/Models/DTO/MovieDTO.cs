namespace Movies.API.Models.DTO
{
    public record MovieDto(
        int Id,
        string Title,
        long Rating,
        DateTime ReleaseDate,
        string Description
    );
}
