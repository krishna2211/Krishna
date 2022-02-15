using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServerDemosValidation.Models;
namespace ServerDemosValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        public ActionResult StudentDetails(StudentModel sm)
        {
            if(string.IsNullOrEmpty(sm.name))
            {
                ModelState.AddModelError("Name", "Name Required");
             }
            if (sm.age==0 ||sm.age>120)
            {
                ModelState.AddModelError("Age", "please enter valid Age");
            }
            if(ModelState.IsValid)
            {
                ViewBag.name = sm.name;
                ViewBag.age = sm.age;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No data";
                ViewBag.age = "No data";
                return View("Index");
            }
        }
    }
}