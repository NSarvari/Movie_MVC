
namespace DataAccess.Repositories
{
    using DataStructure;
    using MovieReviews.Data;
    using System.Collections.Generic;
    using System.Linq;

    public class GenreRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public GenreRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // public List<Movie> GetGenreTypeDrama(string type) => this.context.Genres.Where(Drama => Drama.Type == type).ToList();
        public List<Genre> GetMovieByGenreType(string type)
        {
            return this._appDbContext.Genres.Where(Drama => Drama.Type == type).ToList();
        }
    }
}
