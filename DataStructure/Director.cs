

namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Director : Model
    {
        // MARK: - Class Properties
        [Required(ErrorMessage = "The field cannot be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string DateOfBirth { get; set; }

        // MARK: - 1-to-Many Relationships
        public ICollection<MovieDirector> MovieDirectors { get; set; }
    }
}
