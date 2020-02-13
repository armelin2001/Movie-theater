using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace MovieTheater.Models
{
    public class Movie
    {
        public int Id{get;set;}
        [Required(ErrorMessage="The movie name is to short")]
        [MinLength(5)]
        public string MovieName{get;set;}
        [Required(ErrorMessage="The movie type is to short")]
        [MinLength(3)]
        public string Type{get;set;}
        [Required(ErrorMessage="The movie duration need be bigger then 0")]
        [Range(0,double.MaxValue)]
        public double Duration{get;set;}
        [Required(ErrorMessage="The director name need be bigger then 3 charracters")]
        [MinLength(3)]
        public string Director{get;set;}
        [Required(ErrorMessage="The ticket price need be more to 0")]
        [Range(0,float.MaxValue)]
        public float Price{get;set;}
        [Required(ErrorMessage="Date is required")]
        public DateTime RelaseDateOf{get;set;}//I made a new migartion here because in last commit these variable was double
    }
}