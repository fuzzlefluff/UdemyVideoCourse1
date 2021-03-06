﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UdemyVideoSite.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required] 
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }
        [Required]
        [Display(Name = "Total Movies in Stock")]
        [Range(1,20)]
        public byte Stock { get; set; }
        [Display(Name = "Movies in Stock")]
        [Range(0,20)]
        public byte NumberAvailable{ get; set; } 

    }
}