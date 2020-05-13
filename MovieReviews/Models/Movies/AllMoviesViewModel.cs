using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReviews.Models.Movies
{
    public class AllMoviesViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string ReleasedYear { get; set; }

        public IEnumerable<int> ActorIDs { get; set; }
    }
}
