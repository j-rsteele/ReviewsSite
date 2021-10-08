using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        public Moviecontext db;

        public MovieRepository(Moviecontext db)
        {
            this.db = db;
        }

        // Create
        public void Create(Movie obj)
        {
            db.Movies.Add(obj);
            db.SaveChanges();
        }


        // Read
        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetByID(int id)
        {
            return db.Movies.Find(id);
            //return db.Movies.Where(movie => movie.Name == ....etc.        }
        }

        // Update
        public void Update(Movie obj)
        {
            db.Movies.Update(obj);
            db.SaveChanges();
        }

        // Delete
        public void Delete(Movie obj)
        {
            db.Movies.Remove(obj);
            db.SaveChanges();
        }
    }
}
