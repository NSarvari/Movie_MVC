
namespace DataAccess.Repositories
{
    class UnitOfWork
    {
        private readonly MovieDbContext context;

        private MovieRepository movieRepository;
        private ActorRepository actorRepository;
        private DirectorRepository directorRepository;
        private GenreRepository genreRepository;

        private static UnitOfWork main;
        public static UnitOfWork Main
        {
            get
            {
                if (main == null)
                {
                    main = new UnitOfWork();
                }
                return main;
            }
        }

        public MovieRepository MovieRepository
        {
            get
            {
                if (this.MovieRepository == null)
                {
                    this.movieRepository = new MovieRepository(context);
                }

                return movieRepository;
            }
        }

        public ActorRepository ActorRepository
        {
            get
            {
                if (this.actorRepository == null)
                {
                    this.actorRepository = new ActorRepository();
                }

                return this.actorRepository;
            }
        }

        public DirectorRepository DirectorRepository
        {
            get
            {
                if (this.directorRepository == null)
                {
                    this.directorRepository = new DirectorRepository();
                }

                return this.directorRepository;
            }
        }

        public GenreRepository GenreRepository
        {
            get
            {
                if (this.genreRepository == null)
                {
                    this.genreRepository = new GenreRepository();
                }

                return this.genreRepository;
            }
        }

        private UnitOfWork()
        {
            this.context = new MovieDbContext();
        }

    }
}
