using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Day4.Models;
namespace Web_Day4.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            //TempData["name"] = "krishna";
            Dept dept = new Dept { deptno = 100, dname = "SALES" };
            TempData["Departmentinfo"] = dept;
            return RedirectToAction("About");
        }
        public ActionResult About()
        {

            if (TempData["Departmentinfo"] != null)
            {
                TempData.Keep();
                return RedirectToAction("Contact");
            }
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}