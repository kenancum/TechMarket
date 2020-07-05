using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechMarket.Models;
using TechMarket.DAL;
using System.Data.Entity;
using Npgsql;
namespace TechMarket.Controllers
{
    public class PhoneController : Controller
    {
        
        private readonly StoreContext db = new StoreContext();
        // GET: Phone
        public ActionResult Index(string sortOrder)
        {
            IEnumerable<Phone> list;
            ViewBag.NextSortOrderBrand = sortOrder == null || sortOrder== "descendingBrand" ? "ascendingBrand": "descendingBrand";
            ViewBag.NextSortOrderPrice = sortOrder == null || sortOrder == "descendingPrice" ? "ascendingPrice" : "descendingPrice";
            ViewBag.NextSortOrderModel = sortOrder == null || sortOrder == "descendingModel" ? "ascendingModel" : "descendingModel";

            switch (sortOrder)
            {
                case "ascendingBrand":
                    list = db.Phones.Include(phone => phone.stocks).OrderBy(phone => phone.brand);
                    break;
                case "descendingBrand":
                    list = db.Phones.Include(phone => phone.stocks).OrderByDescending(phone => phone.brand);
                    break;
                case "ascendingPrice":
                    list = db.Phones.Include(phone => phone.stocks).OrderBy(phone => phone.price);
                    break;
                case "descendingPrice":
                    list = db.Phones.Include(phone => phone.stocks).OrderByDescending(phone => phone.price);
                    break;
                case "ascendingModel":
                    list = db.Phones.Include(phone => phone.stocks).OrderBy(phone => phone.model);
                    break;
                case "descendingModel":
                    list = db.Phones.Include(phone => phone.stocks).OrderByDescending(phone => phone.model);
                    break;
                default:
                    list = db.Phones;
                    break;
            }
            return View(list);
        }

        // GET: Phone/Details/5
        public ActionResult Details(int id)
        {
            var phone = db.Phones.Single(obj => obj.PhoneID == id);
            return View(phone);
        }

        // GET: Phone/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Phone/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Phone newPhone = new Phone { brand = collection["brand"], model = collection["model"], price = double.Parse(collection["price"]) };
                db.Phones.Add(newPhone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Phone/Edit/5
        public ActionResult Edit(int id)
        {
            var phone= db.Phones.Single(obj => obj.PhoneID == id);
            return View(phone);
        }

        // POST: Phone/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var phoneModel = db.Phones.Single(obj => obj.PhoneID == id).model= collection["model"];
                var phoneBrand = db.Phones.Single(obj => obj.PhoneID == id).brand= collection["brand"];
                var phonePrice = db.Phones.Single(obj => obj.PhoneID == id).price= double.Parse(collection["price"]);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Phone/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Phone/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
