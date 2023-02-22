using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_Movies.Models;
using Microsoft.EntityFrameworkCore;

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
            // Gets all movie categories and outputs them to a list
            ViewBag.Categories = _MovieContext.Categories.ToList();

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

        // Here is the view to see the list of movies in the database
        public IActionResult ListMovies()
        {
            // This gets all the movies and the movie categories
            var movies = _MovieContext.Movies
                .Include(X => X.Category)
                .ToList();
            return View(movies);
        }

        // This function is the edit function 
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            // This gets the info for the categories and the movie being edited
            ViewBag.Categories = _MovieContext.Categories.ToList();

            var movie = _MovieContext.Movies.Single(x => x.MovieID == movieid);

            return View("AddMovie", movie);
        }

        // This function updates the movie in the database once edited
        [HttpPost]
        public IActionResult Edit(MovieResponse UpdatedMovie)
        {
            // Movie is updated with the updatedmovie variable
            _MovieContext.Update(UpdatedMovie);
            _MovieContext.SaveChanges();

            return RedirectToAction("ListMovies");
        }

        // This delete function gets the movie information and passes it to the delete view
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            // Get the movie info of the movie being deleted
            var movie = _MovieContext.Movies.Single(x => x.MovieID == movieid);

            return View(movie);
        }

        // This function actually deletes the movie after being confirmed by the user
        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            // Here the movie is removed from the database
            _MovieContext.Movies.Remove(mr);
            _MovieContext.SaveChanges();

            return RedirectToAction("ListMovies");
        }
    }
}

