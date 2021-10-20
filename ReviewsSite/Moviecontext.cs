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

			  new Movie() { Id = 1, Title = "Dracula", Rating = "NR", Award = "none", Genre = "Horror", ReleaseYear = 1931 },

			  new Movie() { Id = 2, Title = "House of Frankenstein", Rating = "NR", Award = "none", Genre = "Horror", ReleaseYear = 1944 },

			new Movie() { Id = 3, Title = "The Mummy's Ghost", Rating = "NR", Award = "Saturn", Genre = "Horror", ReleaseYear = 2012 }
			 );


			modelbuilder.Entity<Actor>().HasData(

			  new Actor() { Id = 1, Name = "Bela Lugosi" },

			  new Actor() { Id = 2, Name = "Helen Chandler" },
			  new Actor() { Id = 3, Name = "Boris Karloff" },

			  new Actor() { Id = 4, Name = "Lon Chaney Jr." },

			  new Actor() { Id = 5, Name = "John Carradine" }
	   );

			modelbuilder.Entity<MovieActors>().HasData(

				new MovieActors() { Id = 1, MovieId = 1, ActorId = 1 },

				new MovieActors() { Id = 2, MovieId = 1, ActorId = 2 },
				new MovieActors() { Id = 3, MovieId = 2, ActorId = 3 },
				new MovieActors() { Id = 4, MovieId = 2, ActorId = 4 },
				new MovieActors() { Id = 5, MovieId = 3, ActorId = 4 },
				new MovieActors() { Id = 6, MovieId = 3, ActorId = 5 }
		);

			modelbuilder.Entity<Review>().HasData(
						new Review() { Id = 1, Comment = "Dracula is easily one of the most influential horror films ever released. Released by Universal Pictures in 1931, Dracula starred Bela Lugosi as the titular vampire and effectively established the way that vampire stories would be told for the next century.  Lugosi's costume and mannerisms, including his iconic accent, have long been Dracula staples (\"I vant to suck your blood!\"), and future vampire stories borrowed heavily from the mythology and imagery of Dracula. It's an undisputed classic.", MovieId = 1, Name = "John Doe" },
						new Review() { Id = 2, Comment = "The horror story makes absolutely no sense, but it is so nutty that it makes for a diverting watch.", MovieId = 2, Name = "Jane Doe" },
						new Review() { Id = 3, Comment = "Another effort in laziness with scenes lifted directly from earlier Mummy films. Not fun.", MovieId = 3, Name = "Scott" },
						new Review() { Id = 4, Comment = "Great classic movie with all the trimmings.  The horror is b-grade at best, but very entertaining.", MovieId = 2, Name = "Kevin" },
						new Review() { Id = 5, Comment = "The movie has some good typical Unverisal '40's horror moments. Of course it's nothing too scary, at least not by today's standards but it's very classy and good looking all, with the use of shadows and some handy camera-work.", MovieId = 3, Name = "Paul Chambers" }
			);
		}
	}
}

