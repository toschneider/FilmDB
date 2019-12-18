using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FilmDB.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FilmDB.DAL
{
	public class MovieContext : DbContext
	{
		public MovieContext() : base("MovieContext")
		{

		}
	}
}