using System;
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
        [Required]
        public Genre Genre { get; set; }
        [Required]
        [StringLength(255)]
        public string ReleaseDate { get; set; }
        [Required]
        [StringLength(255)]
        public string DateAdded { get; set; }
        [Required]
        public byte Stock { get; set; }

    }
}