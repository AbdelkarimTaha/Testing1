﻿using MoviesWebsite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesWebsite.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public int? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            GenreId = movie.GenreId;
            NumberInStock = movie.NumberInStock;
        }
    }
}