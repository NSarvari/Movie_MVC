

namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Director : Model
    {
        // MARK: - Class Properties
    
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        // MARK: - 1-to-Many Relationships
        public ICollection<MovieDirector> MovieDirectors { get; set; }
    }
}
