using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UdemyVideoSite.Dtos
{
    public class NewRentalDto
    {
        [Required]
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}