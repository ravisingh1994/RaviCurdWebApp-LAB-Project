using RaviCurdWebApp.MyDB_Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaviCurdWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            STUDENTSINFOEntities obj = new STUDENTSINFOEntities();

            var obj1 = obj.STUDETAILs.ToList();

            return View(obj1);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}