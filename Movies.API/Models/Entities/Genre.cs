
namespace Movies.API.Models.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; } = String.Empty;

        // Skip navigation for the many-to-many relationship with Movie
        public ICollection<Movie> Movies { get; } = [];
    }
}
