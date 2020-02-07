using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTheater.Models;

namespace MovieTheater.DataBase
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Movie> Movies{get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){
        }
    }
}