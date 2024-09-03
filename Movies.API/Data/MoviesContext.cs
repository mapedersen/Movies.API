using Microsoft.EntityFrameworkCore;
using Movies.API.Models.Entities;

namespace Movies.API.Data
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
            
        }
    }
}
