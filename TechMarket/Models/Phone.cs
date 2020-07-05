using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TechMarket.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public double price { get; set; }

        public virtual List<Stock> stocks{ get; set; }

        public Phone(int ID, string Brand, string Model, double Price, List<Stock> Stocks = null)
        {
            PhoneID = ID;
            brand = Brand;
            model = Model;
            price = Price;
            stocks = Stocks;
        }
        public Phone()
        {

        }
    }
}