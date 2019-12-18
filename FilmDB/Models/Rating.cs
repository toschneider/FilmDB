using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class Rating
	{
		public int RatingID { get; set; }
		public int ReviewerID { get; set; }
		public int MovieID { get; set; }
		public int ReviewStars { get; set; }

		public virtual Movie Movie { get; set; }
		public virtual Reviewer Reviewer { get; set; }
	}
}