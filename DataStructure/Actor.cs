
namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Actor : Model
    {
        // MARK: - Class Properties
        [Required(ErrorMessage ="The field cannot be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string Residence { get; set; }

        public string Award { get; set; }

        public string ActorPhoto { get; set; }

        // MARK:- Many-to-Many Relationships
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
