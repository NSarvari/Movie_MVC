
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Movie : Model
    {
        // MARK: - Class Properties
        [Required(ErrorMessage = "The field cannot be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string Scenarist { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string ReleasedYear { get; set; }

        public string Award { get; set; }

        public string Discreption { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string Duration { get; set; }

        public string MoviePoster { get; set; }

        public string MovieTrailer { get; set; }

        // MARK:- Many-to-Many Relationships
        public ICollection<MovieActor> MovieActors { get; set; }

        public ICollection<MovieDirector> MovieDirectors { get; set; }

    }
}
