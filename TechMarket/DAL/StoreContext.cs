using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TechMarket.Models;

namespace TechMarket.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("DBconnString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreContext, TechMarket.Migrations.Configuration>());
        }
        public static StoreContext Create()
        {
            return new StoreContext();
        }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Stock> Stocks{ get; set; }
    }
}