
namespace DataAccess.Repositories
{
    using DataStructure;
    using System.Collections.Generic;
    using System.Linq;

    class GenreRepository : GenericRepository<Genre>
    {
        public GenreRepository() : base(new MovieDbContext())
        {
        }

        // public List<Movie> GetMovieForGenreByID(int id) => this.GetByID(id).Movies.ToList();
        public List<Movie> GetMoviesForDirectorByID(int id)
        {
            return this.GetByID(id).Movies.ToList();
        }

        // public List<Movie> GetGenreTypeDrama(string type) => this.context.Genres.Where(Drama => Drama.Type == type).ToList();
        public List<Genre> GetMovieByGenreType(string type)
        {
            return this.context.Genres.Where(Drama => Drama.Type == type).ToList();
        }
    }
}
