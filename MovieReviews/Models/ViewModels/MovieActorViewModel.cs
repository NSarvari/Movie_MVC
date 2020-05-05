﻿
namespace MovieReviews.Models
{
    using DataStructure;
    using MovieReviews.Models.ViewModels;
    using System.ComponentModel.DataAnnotations;

    public class MovieActorViewModel : ViewModel
    {
        public Movie Movie { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(4)]
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