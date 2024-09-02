using Movies.API.Models.Entities.Relationships;

namespace Movies.API.Models.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public long Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; } = string.Empty;

        public ICollection<Director> Directors { get; } = [];
        public List<MovieDirector> MovieDirectors { get; } = [];
        public List<MovieGenre> MovieGenres { get; } = [];
    }
}
