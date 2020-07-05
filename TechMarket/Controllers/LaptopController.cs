using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TechMarket.Models;
using TechMarket.DAL;
using System.Data.Entity;
using Npgsql;

namespace TechMarket.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }

        // GET: Laptop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Laptop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Laptop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Laptop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Laptop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Laptop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Laptop/Delete/5
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
