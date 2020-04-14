
namespace DataAccess.Repositories
{
    using DataStructure;
    using System.Collections.Generic;
    using System.Linq;

    class MovieRepository : GenericRepository<Movie>
    {
        public MovieRepository(MovieDbContext context) : base(context) { }

        // public List<Movie> GetFilmsByReleasedYear(int year) => this.context.Movies.Where(x => x.ReleasedYear > year).ToList();
        public List<Movie> GetFilmsByReleasedYear(int year)
        {
            return this.context.Movies.Where(x => x.ReleasedYear > year).ToList();
        }
    }
}
