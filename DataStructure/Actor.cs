
namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Actor : Model
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

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string Residence { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(64)]
        public string Award { get; set; }

        // MARK:- Many-to-Many Relationships
        public ICollection<Movie> Movies { get; set; }
    }
}
