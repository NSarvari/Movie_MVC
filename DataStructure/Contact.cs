
namespace DataStructure
{

    using System.ComponentModel.DataAnnotations;
    public class Contact:Model
    {
        [Required(ErrorMessage = "The field cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public string Role { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "The field cannot be empty")]
        public int PhoneNumber { get; set; }
    }
}
