using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataStructure
{
    public class MovieDirector
    {
        [Required(ErrorMessage = "The field cannot be empty")]
        public int movieId { get; set; }
        public Movie Movie { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public int directorId { get; set; }
        public Director Director { get; set; }
    }
}
