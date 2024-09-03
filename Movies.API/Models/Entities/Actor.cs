
namespace Movies.API.Models.Entities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        // Skip navigation for the many-to-many relationship with Movie
        public ICollection<Movie> Movies { get; } = [];
    }
}
