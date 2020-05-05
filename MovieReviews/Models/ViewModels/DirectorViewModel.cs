
namespace MovieReviews.Models.ViewModels
{
    using DataStructure;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class DirectorViewModel : ViewModel
    {
        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string DirectorName { get; set; }

        public ICollection<Movie> Movies { get; set; }

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
