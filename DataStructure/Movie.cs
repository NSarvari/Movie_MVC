
namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Movie : Model
    {
        // MARK: - Class Properties
        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string Title { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string Scenarist { get; set; }

        [Required]
        public int ReleasedYear { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string Award { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string Discreption { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string ImageUrl { get; set; }

        // MARK: - 1-to-1 Relationships
        public Director Director { get; set; }

        // MARK:- Many-to-Many Relationships
        public ICollection<Actor> Actors { get; set; }

        public ICollection<Genre> Genres { get; set; } 
    }
}
