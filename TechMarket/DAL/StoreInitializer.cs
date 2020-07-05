using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TechMarket.Models;
using Microsoft.Ajax.Utilities;

namespace TechMarket.DAL
{
    public class StoreInitializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var phones = new List<Phone>
            {
                new Phone{brand= "Nokia", model="5800", price= 100 },
                new Phone{brand= "Iphone",model= "XS",price =500 },
                new Phone{brand= "Samsung",model="Galaxy Note 10",price =500}
            };
            phones.ForEach(phone => context.Phones.Add(phone));
            context.SaveChanges();
        }
    }
}