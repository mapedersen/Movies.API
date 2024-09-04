namespace Movies.API.Models.Entities
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        // Skip navigation for the many-to-many relationship with Movie
        public ICollection<Movie> Movies { get; } = [];

        // One-to-one relationship with ContactInformation
        public ContactInformation ContactInformation { get; set; } = null!;

    }
}
