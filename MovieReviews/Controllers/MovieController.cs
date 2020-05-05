
namespace MovieReviews.Controllers
{
    using DataStructure;
    using Microsoft.AspNetCore.Mvc;
    using MovieReviews.Models.ViewModels;

    public class MovieController : Controller
    {
        public ViewResult Details()
        {
            ViewBag.Title = "Movie Details Page";
            ViewBag.Header = "Movie's Details";
            //Movies Basic Details
            Movie movie = new Movie()
            {
                ID = 1,
                Title = "Winter's Bone",
                Scenarist = "Daniel Woodrell",
              
                Award = "Oscar",
                Discreption = "Shooting of the movie has happened in the USA",
                ImageUrl = "https://i.pinimg.com/736x/50/01/ba/5001ba39e2cb7db8eae6ccb55c296bdd--top-movies-jennifer-lawrence.jpg"
            };
            //Movie Genre
            Genre genre = new Genre()
            {
                Type = "Drama",
            };
            //Creating the View model
            MovieViewModel movieViewModel = new MovieViewModel()
            {
                Movie = movie,
                Genre = genre,
                Title = "Movie Details Page",
                Header = "Movie's Detials",
            };
            //Pass the movieViewModel to the view
            return View(movieViewModel);
        }
    }
}
