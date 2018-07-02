using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rombooking.Models
{
    public class Branch
    {

        public Branch()
        {
            this.Users = new HashSet<User>();
        }

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}