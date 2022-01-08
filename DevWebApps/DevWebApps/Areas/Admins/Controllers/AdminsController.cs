using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevWebApps.Areas.Admins.Controllers
{
    public class AdminsController : Controller
    {
        // GET: Admins/Admins
        public ActionResult Index()
        {
            return View();
        }
    }
}