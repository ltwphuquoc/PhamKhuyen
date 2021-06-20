using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDunng.Common;
using TestUngDunng.Areas.Admin.Models;
namespace TestUngDunng.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var session = (LoginModel)Session[Constan.USER_SESSION];
            if (session == null)
                return RedirectToAction("Index", "Login");

            return View();
        }

        public ActionResult Logout()
        {
            Session[Constan.USER_SESSION] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}