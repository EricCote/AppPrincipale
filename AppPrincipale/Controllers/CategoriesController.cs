using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppPrincipale.Models;

namespace AppPrincipale.Controllers
{
    public class CategoriesController : Controller
    {
        private AwContext db = new AwContext();

        // GET: Categories
        public ActionResult Index()
        {
            var productCategories = db.ProductCategories.Where(c=>c.ParentCategoryID.HasValue).Include(c => c.Products);
            return View(productCategories.ToList());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.ProductCategories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            ViewBag.ParentCategoryID = new SelectList(db.ProductCategories, "CategoryID", "Name");
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryID,ParentCategoryID,Name,rowguid,ModifiedDate")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.ProductCategories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ParentCategoryID = new SelectList(db.ProductCategories, "CategoryID", "Name", category.ParentCategoryID);
            return View(category);
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.ProductCategories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParentCategoryID = new SelectList(db.ProductCategories, "CategoryID", "Name", category.ParentCategoryID);
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryID,ParentCategoryID,Name,rowguid,ModifiedDate")] Category category)
        {
           
            if (category.ModifiedDate == default (DateTime) )
                category.ModifiedDate = System.DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ParentCategoryID = new SelectList(db.ProductCategories, "CategoryID", "Name", category.ParentCategoryID);
            return View(category);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.ProductCategories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.ProductCategories.Find(id);
            db.ProductCategories.Remove(category);
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
