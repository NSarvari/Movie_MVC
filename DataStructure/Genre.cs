
namespace DataStructure
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Genre : Model
    {
        // MARK: - Class Properties

        public string Type { get; set; }

        public string Note { get; set; }

        // MARK: - 1-to-Many Relationships

        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
