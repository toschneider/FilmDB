using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class Reviewer
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public virtual ICollection<Rating> Ratings { get; set; }
	}
}