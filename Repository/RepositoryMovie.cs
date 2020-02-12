using MovieTheater.DataBase;
using MovieTheater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MovieTheater.Repository
{
    //I made this class because is more safe to use data base in a separete class, so i will instantiate this class in movie controler 
    public class RepositoryMovie
    {
        private readonly ApplicationDbContext database;
        public RepositoryMovie(ApplicationDbContext _dataBase){
            database=_dataBase;
        }  
        public Movie FindMovie(int id){
            var findMovie = database.Movies.FirstOrDefault(movie => movie.Id == id);//this lambida function will take the enter parameter and is gona return a movie
            return findMovie;
        }
        public List<Movie> ListAllMovies(){
            return database.Movies.ToList();
        }
        public void AddMovie(Movie movie){
            database.Movies.Add(movie);//create a new movie in data base
            database.SaveChanges();
        }
        public void Edit(Movie movieEdit){
            /*database.Movies.Attach(movieEdit);
            Link of this function
            https://stackoverflow.com/questions/23644981/how-to-do-patch-update-a-model-using-asp-net-mvc-entity-framework-and-razor
            these functions will check if there is some modification in the attribute, if that happen the attribute is modify 
            database.Entry(movieEdit).Property(movie=> movie.movieName).IsModified=true;
            database.Entry(movieEdit).Property(movie=> movie.type).IsModified=true;
            database.Entry(movieEdit).Property(movie=> movie.Duration).IsModified=true;
            database.Entry(movieEdit).Property(movie=> movie.Price).IsModified=true;
            database.Entry(movieEdit).Property(movie=>movie.RelaseDateOf).IsModified=true;*/
            database.Movies.Update(movieEdit);
            database.SaveChanges();
        }
        public void Delete(Movie deleteMovie){
            database.Movies.Remove(deleteMovie);
            database.SaveChanges();
        }
        public void DetailsRepository(Movie movie){
            database.Movies.Find(movie);
        }
    }
}