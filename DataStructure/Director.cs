

namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Director : Model
    {
        // MARK: - Class Properties
        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string LastName { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string DateOfBirth { get; set; }

        // MARK: - 1-to-Many Relationships
        public ICollection<Movie> Movies { get; set; }
    }
}
