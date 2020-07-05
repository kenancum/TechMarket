using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechMarket.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
    }
}