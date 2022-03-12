using DevWebApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevWebApps.Areas.Admins.Controllers
{
    public class PAYMENT_METHODController : Controller
    {
        private DevWebAppsDBEntities db = new DevWebAppsDBEntities();
        // GET: Admins/PAYMENT_METHOD
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            var data = db.PAYMENT_METHOD.ToList();

            return Json(data,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(PAYMENT_METHOD payment)
        {
            try
            {
                if (payment.CREATED_DATE == null)
                    payment.CREATED_DATE = DateTime.Now;
                if (payment.UPDATED_DATE == null)
                    payment.UPDATED_DATE = DateTime.Now;

                payment.ISDELETE = 0;

                db.PAYMENT_METHOD.Add(payment);
                db.SaveChanges();

                return Json(1, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}