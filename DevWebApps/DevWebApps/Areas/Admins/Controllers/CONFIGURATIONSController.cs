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
    public class CONFIGURATIONSController : Controller
    {
        private DevWebAppsDBEntities db = new DevWebAppsDBEntities();

        // GET: Admins/CONFIGURATIONS
        public ActionResult Index()
        {
            return View(db.CONFIGURATIONS.ToList());
        }

        // GET: Admins/CONFIGURATIONS/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONFIGURATIONS cONFIGURATIONS = db.CONFIGURATIONS.Find(id);
            if (cONFIGURATIONS == null)
            {
                return HttpNotFound();
            }
            return View(cONFIGURATIONS);
        }

        // GET: Admins/CONFIGURATIONS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/CONFIGURATIONS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME,NOTES,ISDELETE,ISACTIVE")] CONFIGURATIONS cONFIGURATIONS)
        {
            if (ModelState.IsValid)
            {
                db.CONFIGURATIONS.Add(cONFIGURATIONS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cONFIGURATIONS);
        }

        // GET: Admins/CONFIGURATIONS/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONFIGURATIONS cONFIGURATIONS = db.CONFIGURATIONS.Find(id);
            if (cONFIGURATIONS == null)
            {
                return HttpNotFound();
            }
            return View(cONFIGURATIONS);
        }

        // POST: Admins/CONFIGURATIONS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME,NOTES,ISDELETE,ISACTIVE")] CONFIGURATIONS cONFIGURATIONS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONFIGURATIONS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cONFIGURATIONS);
        }

        // GET: Admins/CONFIGURATIONS/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONFIGURATIONS cONFIGURATIONS = db.CONFIGURATIONS.Find(id);
            if (cONFIGURATIONS == null)
            {
                return HttpNotFound();
            }
            return View(cONFIGURATIONS);
        }

        // POST: Admins/CONFIGURATIONS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CONFIGURATIONS cONFIGURATIONS = db.CONFIGURATIONS.Find(id);
            db.CONFIGURATIONS.Remove(cONFIGURATIONS);
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
