using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class MovieDirection
	{
		public int MovieDirectionID { get; set; }
		public int MovieID { get; set; }
		public int DirectorID { get; set; }

		public virtual Movie Movie { get; set; }
		public virtual Director Director { get; set; }
	}
}