﻿namespace Movies.API.Models.Entities.Relationships
{
    public class MovieDirector
    {
        public int MovieId { get; set; }
        public int DirectorId { get; set; }
        public Movie Movie { get; set; } = null!;
        public Director Director { get; set; } = null!;
    }
}
