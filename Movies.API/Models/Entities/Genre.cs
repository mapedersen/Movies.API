using Movies.API.Models.Entities.Relationships;

namespace Movies.API.Models.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<MovieGenre> MovieGenres { get; } = [];
    }
}
