
namespace MovieReviews.Models.ViewModels
{
    using DataStructure;
    using System.ComponentModel.DataAnnotations;

    public class ActorViewModel : ViewModel
    {
        public Actor Actor { get; set; }

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
