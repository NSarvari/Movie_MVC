
namespace DataAccess
{
    using DataStructure;
    using System.Data.Entity;

    public partial class MovieDbContext : DbContext
    {
        // MARK: - Class Properties

        /// <summary>
        /// Connection to "Movie" table
        /// </summary>
        public DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// Connection to "Actor" table
        /// </summary>
        public DbSet<Actor> Actors { get; set; }

        /// <summary>
        /// Connection to "Director" table
        /// </summary>
        public DbSet<Director> Directors { get; set; }

        /// <summary>
        /// Connection to "Genre" table
        /// </summary>
        public DbSet<Genre> Genres { get; set; }

        // MARK: - Constructors

        public MovieDbContext()
            : base("name=MovieDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
