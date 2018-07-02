using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rombooking.Models
{
    public class Employee
    {

        public Employee()
        {
            Bookings = new HashSet<Booking>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public bool isEmployed { get; set; }
        public int BranchID { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }


    }
}