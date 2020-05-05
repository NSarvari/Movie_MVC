
namespace MovieReviews.Models.ViewModels
{
    using DataStructure;
    using System.ComponentModel.DataAnnotations;

    public class MovieViewModel : ViewModel
    {

    
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }


        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string Title { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string Header { get; set; }

    }
}
