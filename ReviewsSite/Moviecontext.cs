using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;

namespace ReviewsSite
{
	public class Moviecontext : DbContext
	{
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Actor> Actors { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<MovieActors> MovieActors { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString = "Server=(localdb)\\mssqllocaldb; Database=MovieDB_100721; Trusted_Connection=True";
			optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
			base.OnConfiguring(optionsBuilder);

		}
		protected override void OnModelCreating(ModelBuilder modelbuilder)
		{

			modelbuilder.Entity<Movie>().HasData(

			  new Movie() { Id = 1, Title = "Movie1a1a2", Rating = "R", Award = "none", Genre = "Action", ReleaseYear = 2010 },

			  new Movie() { Id = 2, Title = "Movie2a3a4", Rating = "G", Award = "none", Genre = "Drama", ReleaseYear = 2011 },

			new Movie() { Id = 3, Title = "Movie3a5a2a1", Rating = "PG", Award = "none", Genre = "Comedy", ReleaseYear = 2012 }
			 );


			modelbuilder.Entity<Actor>().HasData(

			  new Actor() { Id = 1, Name = "Actor1", MovieId = 0 },

			  new Actor() { Id = 2, Name = "Actor2", MovieId = 0 },
			  new Actor() { Id = 3, Name = "Actor3", MovieId = 0 },

			  new Actor() { Id = 4, Name = "Actor4", MovieId = 0 },

			  new Actor() { Id = 5, Name = "Actor5", MovieId = 0 }
	   );

			modelbuilder.Entity<MovieActors>().HasData(

				new MovieActors() { Id = 1, MovieId = 1, ActorId = 1 },

				new MovieActors() { Id = 2, MovieId = 1, ActorId = 2 },
				new MovieActors() { Id = 3, MovieId = 2, ActorId = 3 },

				new MovieActors() { Id = 4, MovieId = 2, ActorId = 4 },
				new MovieActors() { Id = 5, MovieId = 3, ActorId = 5 },
				new MovieActors() { Id = 6, MovieId = 3, ActorId = 2 },
				new MovieActors() { Id = 7, MovieId = 3, ActorId = 1 }



		);

			modelbuilder.Entity<Review>().HasData(
						new Review() { Id = 1, Comment = "pretty good", MovieId = 1, Name = "John Doe" },
						new Review() { Id = 2, Comment = "really bad", MovieId = 2, Name = "Jane Doe" },
						new Review() { Id = 3, Comment = "scary", MovieId = 3, Name = "Scott" },
						new Review() { Id = 4, Comment = "delicious", MovieId = 2, Name = "Bob" },
						new Review() { Id = 5, Comment = "supergood", MovieId = 3, Name = "David" }
			);
		}
	}
}

