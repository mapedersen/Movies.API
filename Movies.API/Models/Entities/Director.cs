namespace Movies.API.Models.Entities
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string Name { get; set; } = String.Empty;
        public  DateTime DateOfBirth { get; set; }

        // Skip navigation for the many-to-many relationship with Movie
        public ICollection<Movie> Movies { get; } = [];
        
    }
}
