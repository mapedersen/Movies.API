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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Saving Private Ryan", Rating = 8, ReleaseDate = new DateTime(1998, 7, 24), Description = "A group of U.S. soldiers go behind enemy lines to retrieve a paratrooper." },
                new Movie { MovieId = 2, Title = "Inception", Rating = 9, ReleaseDate = new DateTime(2010, 7, 16), Description = "A thief who enters the dreams of others to steal secrets from their subconscious." }
            );

            // Seed Directors
            modelBuilder.Entity<Director>().HasData(
                new Director { DirectorId = 1, Name = "Steven Spielberg", DateOfBirth = new DateTime(1946, 12, 18) },
                new Director { DirectorId = 2, Name = "Christopher Nolan", DateOfBirth = new DateTime(1970, 7, 30) }
            );

            // Seed Genres
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Action" },
                new Genre { GenreId = 2, Name = "Drama" }
            );

            // Seed Actors
            modelBuilder.Entity<Actor>().HasData(
                new Actor { ActorId = 1, Name = "Tom Hanks", DateOfBirth = new DateTime(1956, 7, 9) },
                new Actor { ActorId = 2, Name = "Leonardo DiCaprio", DateOfBirth = new DateTime(1974, 11, 11) }
            );
        }
    }
}
