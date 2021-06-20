using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelEF.Dao;
using PagedList;
using ModelEF.Model;
namespace TestUngDunng.Areas.Admin.Controllers
{
    public class SanPhamController : BaseController
    {
        // GET: Admin/SanPham
        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var dao = new SPDao();
            var model = dao.getallSP();
            return View(model.ToPagedList(page, pagesize));
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var dao = new SPDao();
            var product = dao.FindbyID(id);
            return View(product);
        }
  [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            model.img = "Null";
            var dao = new SPDao();
            if(ModelState.IsValid)
            {
                int result = dao.insert(model);
                if(result!=0)
                {
                    SetAlert("Thành công!", "success");
                    return RedirectToAction("Index", "SanPham");
                } else
                {
                    SetAlert("Thất bại!", "success");
                }
            }
            SetViewBag();
            return View();
        }
        public void SetViewBag(int? selectedID= null)
        {
            var dao = new CateDao();
            ViewBag.CateID = new SelectList(dao.getAllCate(), "CateID", "Name",selectedID);
        }
    }
}