using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DevWebApps.Models;

namespace DevWebApps.Areas.Admins.Controllers
{
    public class NEWS_CATEGORYController : Controller
    {
        private DevWebAppsDBEntities db = new DevWebAppsDBEntities();

        // GET: Admins/NEWS_CATEGORY
        public ActionResult Index()
        {
            return View(db.NEWS_CATEGORY.ToList());
        }

        // GET: Admins/NEWS_CATEGORY/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NEWS_CATEGORY nEWS_CATEGORY = db.NEWS_CATEGORY.Find(id);
            if (nEWS_CATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(nEWS_CATEGORY);
        }

        // GET: Admins/NEWS_CATEGORY/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/NEWS_CATEGORY/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME,NOTES,ICON,IDPARENT,SLUG,META_TITLE,META_KEYWORD,META_DESCRIPTION,CREATED_DATE,UPDATED_DATE,CREATED_BY,UPDATED_BY,ISDELETE,ISACTIVE")] NEWS_CATEGORY nEWS_CATEGORY)
        {
            if (ModelState.IsValid)
            {
                db.NEWS_CATEGORY.Add(nEWS_CATEGORY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nEWS_CATEGORY);
        }

        // GET: Admins/NEWS_CATEGORY/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NEWS_CATEGORY nEWS_CATEGORY = db.NEWS_CATEGORY.Find(id);
            if (nEWS_CATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(nEWS_CATEGORY);
        }

        // POST: Admins/NEWS_CATEGORY/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME,NOTES,ICON,IDPARENT,SLUG,META_TITLE,META_KEYWORD,META_DESCRIPTION,CREATED_DATE,UPDATED_DATE,CREATED_BY,UPDATED_BY,ISDELETE,ISACTIVE")] NEWS_CATEGORY nEWS_CATEGORY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nEWS_CATEGORY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nEWS_CATEGORY);
        }

        // GET: Admins/NEWS_CATEGORY/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NEWS_CATEGORY nEWS_CATEGORY = db.NEWS_CATEGORY.Find(id);
            if (nEWS_CATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(nEWS_CATEGORY);
        }

        // POST: Admins/NEWS_CATEGORY/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            NEWS_CATEGORY nEWS_CATEGORY = db.NEWS_CATEGORY.Find(id);
            db.NEWS_CATEGORY.Remove(nEWS_CATEGORY);
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
