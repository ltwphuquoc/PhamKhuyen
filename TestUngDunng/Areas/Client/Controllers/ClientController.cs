using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelEF.Model;
using ModelEF.Dao;
namespace TestUngDunng.Areas.Client.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client/Client
        public ActionResult Index()
        {
            var dao = new SPDao();
            var model = dao.getallSP();            
            return View(model);
        }
        
    }
}