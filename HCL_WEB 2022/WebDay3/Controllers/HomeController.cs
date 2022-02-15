using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDay3.Models;
namespace WebDay3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Dept dobj = new Dept { deptno = 100, dname = "Marketing", location = "Mumbai" };
            return View(dobj);
        }

        public RedirectToRouteResult About()
        {
            ViewBag.Message = "Your application description page.";

            return RedirectToRoute(new { controller = "Home", action = "Contact" });
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MyIndex()
        {
            ViewBag.Msg = ViewBag.Message; // Assigned value : Null
            return View("MyIndex");
        }
    }
}