
namespace DataAccess.Repositories
{
    using DataStructure;
    using MovieReviews.Data;
    using System.Collections.Generic;
    using System.Linq;

    public class DirectorRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public DirectorRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // public List<Director> GetDirectorByDateOfBirth(string dateOfBirth) => this.context.Directors.Where(x => x.DateOfBirth == dateOfBirth).ToList();
        public List<Director> GetDirectorsByDateOfBirth(string dateOfBirth)
        {
            return this._appDbContext.Directors.Where(x => x.DateOfBirth == dateOfBirth).ToList();
        }
    }
}
