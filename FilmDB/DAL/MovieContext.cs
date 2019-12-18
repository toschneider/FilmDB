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
		public DbSet<Actor> Actors { get; set; }
		public DbSet<Director> Directors { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MovieCast> MovieCasts { get; set; }
		public DbSet<MovieCastRole> MovieCastRoles { get; set; }
		public DbSet<MovieDirection> MovieDirections { get; set; }
		public DbSet<MovieGenre> MovieGenres { get; set; }
		public DbSet<Rating> Ratings { get; set; }
		public DbSet<Reviewer> Reviewers { get; set; }
		public DbSet<Role> Roles { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}