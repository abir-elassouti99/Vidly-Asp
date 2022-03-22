using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModel;
namespace Vidly1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var Movies = new List<Movie>() {
            new Movie(){Id=1,Name="Frozen" },
            new Movie(){Id=2,Name="Frozen1" },
            new Movie(){Id=3,Name="Frozen2" },
            new Movie(){Id=4,Name="Frozen3" }
        };
            CustomerMovieViewModel viewModel = new CustomerMovieViewModel()
            {
                Movies = Movies
            };
            return View(viewModel);
        }
    }
}