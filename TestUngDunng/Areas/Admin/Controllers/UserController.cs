using ModelEF.Dao;
using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDunng.Areas.Admin.Models;
using TestUngDunng.Common;

namespace TestUngDunng.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var userdao = new UserDao();
            var model = userdao.getalluser();
            return View(model.ToPagedList(page, pagesize));
        }
        [HttpPost]
        public ActionResult Index(string searchstring, int page = 1, int pagezise = 5)
        {
            var userdao = new UserDao();
            var model = userdao.getsearchuser(searchstring, page, pagezise);
            ViewBag.SearchString = searchstring;
            return View(model);
        }
        [HttpDelete]
        public ActionResult Delete(String username)
        {
            var dao = new UserDao();
            var result = dao.Delete(username);
            return RedirectToAction("Index");
          
        }
        
    }   
}