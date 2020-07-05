namespace TechMarket.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using TechMarket.Models;
    using Npgsql;


    internal sealed class Configuration : DbMigrationsConfiguration<TechMarket.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TechMarket.DAL.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.
            var phones = new List<Phone>
            {
                new Phone{brand= "Nokia", model="5800", price= 100 },
                new Phone{brand= "Iphone",model= "XS",price =500 },
                new Phone{brand= "Samsung",model="Galaxy Note 10",price =500}
            };
            phones.ForEach(phone => context.Phones.AddOrUpdate(obj => obj.model, phone));
            context.SaveChanges();

            var stocks = new List<Stock>
            {
                new Stock{ SerialNumber = "A001", Available=true, Phone=phones[0], PhoneID=phones[0].PhoneID},
                new Stock{ SerialNumber = "A002", Available=false, Phone=phones[0], PhoneID=phones[0].PhoneID},
                new Stock{ SerialNumber = "A003", Available=true, Phone=phones[0], PhoneID=phones[0].PhoneID},
                new Stock{ SerialNumber = "A004", Available=true, Phone=phones[1], PhoneID=phones[1].PhoneID},
                new Stock{ SerialNumber = "A005", Available=false, Phone=phones[2], PhoneID=phones[2].PhoneID},
            };
            stocks.ForEach(c => context.Stocks.AddOrUpdate(obj => obj.SerialNumber, c));
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
