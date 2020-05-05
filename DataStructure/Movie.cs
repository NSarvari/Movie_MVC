
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Movie : Model
    {
        // MARK: - Class Properties
        public string Title { get; set; }

        public string Scenarist { get; set; }


        public string ReleasedYear { get; set; }

        public string Award { get; set; }

        public string Discreption { get; set; }

        public string ImageUrl { get; set; }


        // MARK:- Many-to-Many Relationships
        public ICollection<MovieActor> MovieActors { get; set; }

        public ICollection<MovieDirector> MovieDirectors { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; } 
    }
}
