using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmDB.Models;
using FilmDB.DAL;

namespace FilmDB.Controllers
{
    public class MovieViewModelController : Controller
    {
        private MovieContext dv = new MovieContext();
        // GET: MovieViewModel
        public ActionResult Index()
        {
            return View();
        }
    }
}