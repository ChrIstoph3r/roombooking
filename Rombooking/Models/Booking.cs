using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rombooking.Models
{
    public class Booking
    {

        public Booking()
        {
            Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int CompanyID { get; set; }
        public int RoomID { get; set; }

        public virtual Room Room { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<Employee> Employees{ get; set; }
    }
}