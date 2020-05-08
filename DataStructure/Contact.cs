using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Contact:Model
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }
    }
}
