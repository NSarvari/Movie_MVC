
namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Genre : Model
    {
        // MARK: - Class Properties

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string Type { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(99)]
        public string Note { get; set; }

        // MARK: - 1-to-Many Relationships

        public ICollection<Movie> Movies { get; set; }
    }
}
