
namespace DataAccess.Repositories
{
    using DataStructure;
    using MovieReviews.Data;
    using System.Collections.Generic;
    using System.Linq;

    public class ActorRepository 
    {
        private readonly ApplicationDbContext _appDbContext;

        public ActorRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // public List<Actor> GetActorsByFirstName(string firstName) => this.context.Actors.Where(x => x.FirstName == firstName).ToList();
        public List<Actor> GetActorsByFirstName(string firstName)
        {
            return this._appDbContext.Actors.Where(x => x.FirstName == firstName).ToList();
        }
    }
}
