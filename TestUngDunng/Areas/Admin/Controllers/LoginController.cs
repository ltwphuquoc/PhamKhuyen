using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDunng.Areas.Admin.Models;
using ModelEF.Dao;
using TestUngDunng.Common;
namespace TestUngDunng.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel user)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.loginDao(user.userName, user.passWord);
                if(result==1)
                {
                    Session.Add(Constan.USER_SESSION, user);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại");
                }
            }
            return View("Index");
        }
    }
}