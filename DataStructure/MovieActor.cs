using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure
{
    public class MovieActor
    {
        [Required(ErrorMessage = "The field cannot be empty")]
        public int movieId { get; set; }
        public Movie Movie{ get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public int actorId { get; set; }
        public Actor Actor { get; set; }
    }
}
