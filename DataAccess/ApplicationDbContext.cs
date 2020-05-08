
namespace MovieReviews.Data
{
    using DataStructure;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // many to many for Movies and Actors
            modelBuilder.Entity<MovieActor>()
                .HasKey(t => new { t.movieId, t.actorId });

            modelBuilder.Entity<MovieActor>()
                .HasOne(pt => pt.Movie)
                .WithMany(p => p.MovieActors)
                .HasForeignKey(pt => pt.movieId);

            modelBuilder.Entity<MovieActor>()
                .HasOne(pt => pt.Actor)
                .WithMany(t => t.MovieActors)
                .HasForeignKey(pt => pt.actorId);

            // many to many for Movies and Directors
            modelBuilder.Entity<MovieDirector>()
                .HasKey(t => new { t.movieId, t.directorId });

            modelBuilder.Entity<MovieDirector>()
                .HasOne(pt => pt.Movie)
                .WithMany(p => p.MovieDirectors)
                .HasForeignKey(pt => pt.movieId);

            modelBuilder.Entity<MovieDirector>()
                .HasOne(pt => pt.Director)
                .WithMany(t => t.MovieDirectors)
                .HasForeignKey(pt => pt.directorId);

    
        }
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
        public DbSet<Contact> Contacts { get; set; }

        // MARK: - Constructors

    }
}
