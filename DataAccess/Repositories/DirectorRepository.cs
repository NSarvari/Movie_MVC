
namespace DataAccess.Repositories
{
    using DataStructure;
    using System.Collections.Generic;
    using System.Linq;

    class DirectorRepository : GenericRepository<Director>
    {
        public DirectorRepository() : base(new MovieDbContext())
        {
        }

        // public List<Movie> GetMovieForDirectorByID(int id) => this.GetByID(id).Movies.ToList();
        public List<Movie> GetMoviesForDirectorByID(int id)
        {
            return this.GetByID(id).Movies.ToList();
        }

        // public List<Director> GetDirectorByDateOfBirth(string dateOfBirth) => this.context.Directors.Where(x => x.DateOfBirth == dateOfBirth).ToList();
        public List<Director> GetDirectorsByDateOfBirth(string dateOfBirth)
        {
            return this.context.Directors.Where(x => x.DateOfBirth == dateOfBirth).ToList();
        }
    }
}
