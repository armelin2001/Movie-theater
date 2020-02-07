using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieTheater.Repository;
using MovieTheater.DataBase;
using MovieTheater.Models;
namespace MovieTheater.Controllers
{
    public class MovieController:Controller
    {   

        /*link about http methods in mvc
        https://www.tutorialsteacher.com/mvc/actionverbs-in-mvc*/
        private readonly RepositoryMovie movieRepository;
        public MovieController(RepositoryMovie _movieRepository){
            movieRepository = _movieRepository;
        }
        [HttpGet]
        public ActionResult ShowMovies(){
            var listMovies = movieRepository.ListAllMovies();
            return View(listMovies);
        }
    }
}