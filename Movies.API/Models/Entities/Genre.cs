
namespace Movies.API.Models.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<Movie> Movies { get; } = [];
    }
}
