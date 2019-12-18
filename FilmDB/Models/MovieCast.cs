using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class MovieCast
	{
		public int MovieCastID { get; set; }
		public int MovieID { get; set; }
		public int ActorID { get; set; }

		public virtual Movie Movie { get; set; }
		public virtual Actor Actor { get; set; }

		public virtual ICollection<MovieCastRole> MovieCastRoles { get; set; }
	}
}