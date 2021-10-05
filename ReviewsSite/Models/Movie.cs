using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Rating { get; set; }
		public string Genre { get; set; }
		public int ReleaseYear { get; set; }
		public string Award { get; set; }
		public virtual List<Actor> Actors { get; set; }
	}

	public class Actor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int MovieId { get; set; }
	}

}
