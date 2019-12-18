using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class Role
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public virtual ICollection<MovieCastRole> MovieCastRoles { get; set; }
	}
}