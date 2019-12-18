using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class MovieViewModel
	{
		public Movie Movie { get; set; }
		public List<Actor> Actors { get; set; }
		public List<Director> Directors { get; set; }
		public List<Genre> Genres { get; set; }
		public List<Rating> Ratings { get; set; }
	}
}