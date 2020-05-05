using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class MovieDirector
    {
        public int movieId { get; set; }
        public Movie Movie { get; set; }

        public int directorId { get; set; }
        public Director Director { get; set; }
    }
}
