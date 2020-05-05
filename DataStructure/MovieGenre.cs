using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class MovieGenre
    {
        public int movieId { get; set; }
        public Movie Movie { get; set; }

        public int genreId { get; set; }
        public Genre Genre { get; set; }
    }
}
