using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieTheater.Repository;
using MovieTheater.Models;

namespace MovieTheater.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositoryMovie _repositoryMovie;
        public HomeController(ILogger<HomeController> logger, RepositoryMovie movieRepo)
        {
            _logger = logger;
            _repositoryMovie = movieRepo;
        }

        public IActionResult Index()
        {
            return View(_repositoryMovie.ListAllMovies());
        }

        public IActionResult Privacy()
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
