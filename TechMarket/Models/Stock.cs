using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechMarket.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public bool Available { get; set; }
        public int PhoneID { get; set; }
        public string SerialNumber { get; set; }
        public virtual Phone Phone{ get; set; }

        public Stock(int id, bool available, int phoneId)
        {
            ID = id;
            Available = available;
            PhoneID = phoneId;
        }
        public Stock()
        {

        }
    }
}