
namespace DataAccess.Repositories
{
    using DataStructure;
    using MovieReviews.Data;
    using System.Collections.Generic;
    using System.Linq;

    public class MovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // public List<Movie> GetMoviesByTitle(int year) => this.context.Movies.Where(x => x.Title == title).ToList();
        public List<Movie> GetMoivesByFirstName(string title)
        {
            return this._appDbContext.Movies.Where(x => x.Title == title).ToList();
        }
    }
}
