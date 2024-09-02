using Movies.API.Models.Entities.Relationships;

namespace Movies.API.Models.Entities
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string Name { get; set; } = String.Empty;
        public  DateTime DateOfBirth { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
        public List<MovieDirector> MovieDirectors { get; } = [];
    }
}
