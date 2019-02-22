using MongoDB.Driver;
using Semana05.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana05.Controllers
{
    public class AnimalsController : Controller
    {
        public MongoClient server = new MongoClient(System.Configuration.ConfigurationManager.AppSettings.Get("MongoConnection"));
       static public IMongoDatabase database = server.GetDatabase(System.Configuration.ConfigurationManager.AppSettings.Get("databaseName"));
     

        public AnimalsController()
        {
            var server = new MongoClient(System.Configuration.ConfigurationManager.AppSettings.Get("MongoConnection"));
            var database = server.GetDatabase(System.Configuration.ConfigurationManager.AppSettings.Get("databaseName"));
            var animales = database.GetCollection<Animales> ("animals");
        }
        // GET: Animals
        public ActionResult Index()
        {
           // return Json(database.GetStats)
        }

        // GET: Animals/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Animals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animals/Create
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

        // GET: Animals/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animals/Edit/5
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

        // GET: Animals/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Animals/Delete/5
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
