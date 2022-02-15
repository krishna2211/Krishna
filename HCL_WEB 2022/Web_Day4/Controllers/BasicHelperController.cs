using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Day4.Controllers
{
    public class BasicHelperController : Controller
    {
        // GET: BasicHelper
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Index(string txtUserName, string Gender, string Address)
        {
          
                ViewData["txtUserName"] = txtUserName;
                ViewData["Gender"] = Gender;
                ViewData["Address"] = Address;

                return View("Index");
           
        }
    }
}