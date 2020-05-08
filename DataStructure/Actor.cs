
namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Actor : Model
    {
        // MARK: - Class Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public string Residence { get; set; }

        public string Award { get; set; }

        public string ActorPhoto { get; set; }

        // MARK:- Many-to-Many Relationships
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
