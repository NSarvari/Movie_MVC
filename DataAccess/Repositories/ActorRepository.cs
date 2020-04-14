
namespace DataAccess.Repositories
{
    using DataStructure;
    using System.Collections.Generic;
    using System.Linq;

    class ActorRepository : GenericRepository<Actor>
    {
        public ActorRepository() : base(new MovieDbContext())
        { 
        }

        // public List<Actor> GetActorsByFirstName(string firstName) => this.context.Actors.Where(x => x.FirstName == firstName).ToList();
        public List<Actor> GetActorsByFirstName(string firstName)
        {
            return this.context.Actors.Where(x => x.FirstName == firstName).ToList();
        }

        // public List<Movie> GetMovieForActorByID(int id) => this.GetByID(id).Movies.ToList();
        public List<Movie> GetFilmsForActorByID(int id)
        {
            return this.GetByID(id).Movies.ToList();
        }
    }
}
