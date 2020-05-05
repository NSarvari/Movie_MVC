using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class MovieActor
    {
        public int movieId { get; set; }
        public Movie Movie{ get; set; }

        public int actorId { get; set; }
        public Actor Actor { get; set; }
    }
}
