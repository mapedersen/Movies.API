namespace Movies.API.Models.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public long Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; } = string.Empty;

        // Foreign key
        public int DirectorId { get; set; }

        // Navigation property
        public Director Director { get; set; } = null!;

        // Many-to-many relationship with skip navigation
        public ICollection<Actor> Actors { get; } = [];
        public ICollection<Genre> Genres { get; } = [];

    }
}
