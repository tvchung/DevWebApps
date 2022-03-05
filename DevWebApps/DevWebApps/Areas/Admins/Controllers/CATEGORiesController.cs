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
    public class CATEGORiesController : Controller
    {
        private DevWebAppsDBEntities db = new DevWebAppsDBEntities();

        // GET: Admins/CATEGORies
        public ActionResult Index()
        {

            return View(db.CATEGORY.ToList());
        }

        // GET: Admins/CATEGORies/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY cATEGORY = db.CATEGORY.Find(id);
            if (cATEGORY == null)
            {
                return HttpNotFound();
            }
            // tạo nguồn dữ liệu cho danh mục
            ViewBag.Category = db.CATEGORY.Where(x => x.ISDELETE == 0 && x.ISACTIVE == 0 && x.IDPARENT == null).ToList();
            return View(cATEGORY);
        }

        // GET: Admins/CATEGORies/Create
        public ActionResult Create()
        {
            // tạo nguồn dữ liệu cho danh mục
            ViewBag.Category = db.CATEGORY.Where(x =>x.ISDELETE==0 && x.ISACTIVE ==0 && x.IDPARENT == null).ToList();
            return View();
        }

        // POST: Admins/CATEGORies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME,NOTES,ICON,IDPARENT,SLUG,META_TITLE,META_KEYWORD,META_DESCRIPTION,CREATED_DATE,UPDATED_DATE,CREATED_BY,UPDATED_BY,ISDELETE,ISACTIVE")] CATEGORY cATEGORY)
        {
            if (cATEGORY.IDPARENT.Value==0)
                cATEGORY.IDPARENT = null; 
            if (ModelState.IsValid)
            {
                if (cATEGORY.CREATED_DATE == null) cATEGORY.CREATED_DATE = DateTime.Now;
                if (cATEGORY.UPDATED_DATE == null) cATEGORY.UPDATED_DATE = DateTime.Now;
                if (cATEGORY.CREATED_BY == null) cATEGORY.CREATED_BY = 0;
                if (cATEGORY.UPDATED_BY == null) cATEGORY.UPDATED_BY = 0;

                cATEGORY.ISDELETE = 0;

                db.CATEGORY.Add(cATEGORY);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cATEGORY);
        }

        // GET: Admins/CATEGORies/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY cATEGORY = db.CATEGORY.Find(id);

            if (cATEGORY == null)
            {
                return HttpNotFound();
            }
            // tạo nguồn dữ liệu cho danh mục
            ViewBag.Category = db.CATEGORY.Where(x => x.ISDELETE == 0 && x.ISACTIVE == 0 && x.IDPARENT == null).ToList();
            return View(cATEGORY);
        }

        // POST: Admins/CATEGORies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME,NOTES,ICON,IDPARENT,SLUG,META_TITLE,META_KEYWORD,META_DESCRIPTION,CREATED_DATE,UPDATED_DATE,CREATED_BY,UPDATED_BY,ISDELETE,ISACTIVE")] CATEGORY cATEGORY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cATEGORY).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cATEGORY);
        }

        // GET: Admins/CATEGORies/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY cATEGORY = db.CATEGORY.Find(id);
            if (cATEGORY == null)
            {
                return HttpNotFound();
            }

            // tạo nguồn dữ liệu cho danh mục
            ViewBag.Category = db.CATEGORY.Where(x => x.ISDELETE == 0 && x.ISACTIVE == 0 && x.IDPARENT == null).ToList();
            return View(cATEGORY);
        }

        // POST: Admins/CATEGORies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CATEGORY cATEGORY = db.CATEGORY.Find(id);
            db.CATEGORY.Remove(cATEGORY);
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
