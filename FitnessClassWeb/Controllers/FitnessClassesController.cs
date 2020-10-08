using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FitnessClassWeb.Models.MVC;

namespace FitnessClassWeb.Controllers
{
    public class FitnessClassesController : Controller
    {
        private MVCModel db = new MVCModel();

        // GET: FitnessClasses
        public ActionResult Index()
        {
            // LINQ
            var fClass = (from fc in db.FitnessClasses
                          orderby fc.classID
                          ascending
                          select fc);                        

            return View(fClass.ToList());            
        }
             

        // GET: FitnessClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FitnessClasses fitnessClasses = db.FitnessClasses.Find(id);
            if (fitnessClasses == null)
            {
                return HttpNotFound();
            }
            return View(fitnessClasses);
        }

        // GET: FitnessClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FitnessClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "classID,classTitle,classDescription,active,thumbnail,image")] FitnessClasses fitnessClasses)
        {
            if (ModelState.IsValid)
            {
                db.FitnessClasses.Add(fitnessClasses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fitnessClasses);
        }

        // GET: FitnessClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FitnessClasses fitnessClasses = db.FitnessClasses.Find(id);
            if (fitnessClasses == null)
            {
                return HttpNotFound();
            }
            return View(fitnessClasses);
        }

        // POST: FitnessClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "classID,classTitle,classDescription,active,thumbnail,image")] FitnessClasses fitnessClasses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fitnessClasses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fitnessClasses);
        }

        // GET: FitnessClasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FitnessClasses fitnessClasses = db.FitnessClasses.Find(id);
            if (fitnessClasses == null)
            {
                return HttpNotFound();
            }
            return View(fitnessClasses);
        }

        // POST: FitnessClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FitnessClasses fitnessClasses = db.FitnessClasses.Find(id);
            db.FitnessClasses.Remove(fitnessClasses);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
