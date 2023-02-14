using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_Movies.Models;

namespace Mission06_Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // This allows movies to be saved to the database from the form in the controller
        private AddMovieContext _MovieContext { get; set; }


        public HomeController(ILogger<HomeController> logger, AddMovieContext x)
        {
            _logger = logger;
            _MovieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // this functions handles the posting of movies to the database and checks to make sure the model state is valid
        [HttpPost]
        public IActionResult AddMovie(MovieResponse model)
        {
            // If model is valid then the user is returned to the homepage
            if (ModelState.IsValid)
            {
                _MovieContext.Add(model);
                _MovieContext.SaveChanges();
                return View("Index");
            }

            // Else then the page is returned with the model information
            return View(model);
        }

        // This view gets the AddMovie form that allows the user to add movies to the database
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // Here is the view for the Podcasts page that contains the link to the baconsale website
        public IActionResult Podcasts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

