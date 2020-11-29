using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyVideoSite.Models;

namespace UdemyVideoSite.ViewModels
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}