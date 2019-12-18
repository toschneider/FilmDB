using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class MovieGenre
	{
		public int MovieGenresID { get; set; }
		public int MovieID { get; set; }
		public int GenreID { get; set; }

		public virtual Movie Movie { get; set; }
		public virtual Genre Genre { get; set; }
	}
}