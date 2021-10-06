using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
	public class Actor
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int MovieId { get; set; }
		public virtual List<MovieActors> Movies { get; set; }
	}

}
