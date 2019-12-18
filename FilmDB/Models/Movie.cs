using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmDB.Models
{
	public class Movie
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Length { get; set; }
		public DateTime ReleaseDate { get; set; }
		public FormatEnum Format { get; set; }
		public bool Original { get; set; }
		public OwnerEnum Owner { get; set; }
		public string IMDbURL { get; set; }
		public string ImageURL { get; set; }

		public virtual ICollection<MovieGenre> Genres { get; set; }
		public virtual ICollection<MovieCast> Actors { get; set; }
		public virtual ICollection<MovieDirection> Directors { get; set; }
	}

	public enum FormatEnum
	{
		BD,
		DVD,
		BD3D
	}

	public enum OwnerEnum
	{
		MS,
		TS,
		NS,
		CS
	}
}