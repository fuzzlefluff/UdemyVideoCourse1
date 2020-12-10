using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UdemyVideoSite.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the Customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Birthday")]
        [Min18YearIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        [Required(ErrorMessage = "Must Select a Membership Type!")]
        public byte MembershipTypeId { get; set; }
    }
}