using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EducationManager.Models;

namespace EducationManager.Areas.Admin.Controllers
{
    public class academicyearsController : Controller
    {
        private educationmanagerEntities db = new educationmanagerEntities();

        // GET: Admin/academicyears
        public ActionResult Index()
        {
            return View(db.academicyear.ToList());
        }

        // GET: Admin/academicyears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            academicyear academicyear = db.academicyear.Find(id);
            if (academicyear == null)
            {
                return HttpNotFound();
            }
            return View(academicyear);
        }

        // GET: Admin/academicyears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/academicyears/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] academicyear academicyear)
        {
            if (ModelState.IsValid)
            {
                db.academicyear.Add(academicyear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(academicyear);
        }

        // GET: Admin/academicyears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            academicyear academicyear = db.academicyear.Find(id);
            if (academicyear == null)
            {
                return HttpNotFound();
            }
            return View(academicyear);
        }

        // POST: Admin/academicyears/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] academicyear academicyear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(academicyear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(academicyear);
        }

        // GET: Admin/academicyears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            academicyear academicyear = db.academicyear.Find(id);
            if (academicyear == null)
            {
                return HttpNotFound();
            }
            return View(academicyear);
        }

        // POST: Admin/academicyears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            academicyear academicyear = db.academicyear.Find(id);
            db.academicyear.Remove(academicyear);
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
