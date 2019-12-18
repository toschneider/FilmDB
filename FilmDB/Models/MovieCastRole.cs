using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class MovieCastRole
	{
		public int MovieCastRolesID { get; set; }
		public int MovieCastID { get; set; }
		public int RoleID { get; set; }

		public virtual MovieCast MovieCast { get; set; }
		public virtual Role Role { get; set; }
	}
}