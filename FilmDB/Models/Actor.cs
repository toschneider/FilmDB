using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class Actor
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string IMDbURL { get; set; }
		public string ImageURL { get; set; }

		public virtual ICollection<MovieCast> MovieCasts { get; set; }
	}
}