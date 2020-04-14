
namespace DataAccess.Repositories
{
    using DataStructure;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public abstract class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : Model
    {
        private bool disposed = false;

        /// <summary>
        /// Instance of class DBContext
        /// </summary>
        public readonly MovieDbContext context;

        /// <summary>
        /// Database table type
        /// The value of "T" will be inherid from child class
        /// ----------
        /// EXAMPLE
        /// 1. DBSet<T> where T : Model
        /// 2. class Film : Model
        /// 3. T.Type = Film
        /// 4. DBSet<Film>
        /// 5. ../DBContext.cs/line:16
        /// </summary>
        readonly DbSet<T> entities;

        public GenericRepository(MovieDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // public List<T> GetAll() => entities.ToList();
        public List<T> GetAll()
        {
            return entities.ToList();
        }

        /// <summary>
        /// Add new record to the database
        /// If passed object already exists, update it
        /// </summary>
        /// <param name="entity">Instance of data model class</param>
        public void CreateOrUpdate(T entity)
        {
            DateTime currentDateTime = DateTime.Now;

            // Creating new instance, ID's initial value is 0
            // The ID generate it's value after commiting to database
            if (entity.ID == 0)
            {
                // Set value only before first commit
                entity.CreatedAt = currentDateTime;
            }
            // Set value for each commit
            entity.UpdatedAt = currentDateTime;

            // Add new record in table or update if exists
            entities.AddOrUpdate(entity);

            context.SaveChanges();
        }

        /// <summary>
        /// Delete record from database
        /// </summary>
        /// <param name="id">Object's ID</param>
        public void Delete(int id)
        {
            // Find instance of specific database model type with specific ID
            T entity = entities.Find(id);
            if (entity != null)
            {
                // Remove record from database
                entities.Remove(entity);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Return instance of specific data type
        /// Return value is optional
        /// </summary>
        /// <param name="id">Object's ID</param>
        /// <returns></returns>
        public T GetByID(int id)
        {
            return entities.Find(id);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                context.Dispose();
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(obj: this);
        }

    }
}
