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
        [Required]
        [MinLength(5,ErrorMessage="The movie name is to short")]
        public string MovieName{get;set;}
        [Required]
        [MinLength(3,ErrorMessage="The movie type is to short")]
        public string Type{get;set;}
        [Required]
        [Range(0,double.MaxValue,ErrorMessage="The movie duration need be bigger then 0")]
        public double Duration{get;set;}
        [Required]
        [MinLength(3,ErrorMessage="The director name need be bigger then 3 charracters")]
        public string Director{get;set;}
        [Required]
        [Range(0,float.MaxValue,ErrorMessage="The ticket price need be more to 0")]
        public float Price{get;set;}
        [Required]
        [Range(0,double.MaxValue,ErrorMessage="Please put a correct date")]
        public double RelaseDateOf{get;set;}
    }
}