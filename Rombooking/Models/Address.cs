using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rombooking.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int PostalCode { get; set; }
        public string PostalArea { get; set; }
    }
}