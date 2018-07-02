using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rombooking.Models
{
    public class Company
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set;}
        [Required]
        public int OrgNum { get; set; }
        public int AddressID { get; set; }

        public virtual Address Address{ get; set; }
    }
}