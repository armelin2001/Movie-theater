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
        https://www.tutorialsteacher.com/mvc/actionverbs-in-mvc     
        */
        private readonly RepositoryMovie movieRepository;//call movie repository
        public MovieController(RepositoryMovie _movieRepository){
            movieRepository = _movieRepository;
        }
        [HttpGet]
        public IActionResult NewMovieForm(){//I made this class because i need to load a form before to load a method who will apply the method NewMovie 
            return View();
        }
        [HttpPost]
        public ActionResult NewMovie(Movie movie){
            movieRepository.AddMovie(movie);
            return Redirect("../Home/Index");//return to home page
        }
        public IActionResult ShowMovies(){
            return View(movieRepository.ListAllMovies());//show all movies in home page
        }

        [HttpDelete]
        public ActionResult DeleteMovie(int id){
            var movie = movieRepository.FindMovie(id);
            movieRepository.Delete(movie);
            return Redirect("../Home/Index");//redirect a home page
        }
        public IActionResult DetailsId(int id){
            var movie = movieRepository.FindMovie(id);
            return View(movie);//redirect to a new page who will contain a descrition about movie

        }
        [HttpPost]
        public IActionResult ShowDetailsMovie(Movie movieDetail){
            movieRepository.Details(movieDetail);
            return View();
        }

    }
}