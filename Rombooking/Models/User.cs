using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rombooking.Models
{
    public class User
    {
        public User()
        {
            Branches = new HashSet<Branch>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }

    }
}