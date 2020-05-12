using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReviews.Models.Directors
{
    public class AllDirectorsViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName  { get; set; }

        public string DateOfBirth { get; set; }

        public IEnumerable<int> MovieIDs { get; set; }
    }
}
