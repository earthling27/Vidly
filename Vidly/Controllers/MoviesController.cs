using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "The Dark Night"
            };

            return View(movie);


        }

        public ActionResult Edit(int id)
        {
            return Content("ID = " + id); 
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if(String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("PageIndex = {0} &sortBy = {1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int Year,int Month)
        {
            return Content(Year+"/"+Month);
        }
    }
}