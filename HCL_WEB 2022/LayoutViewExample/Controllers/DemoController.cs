using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayoutViewExample.Models;
namespace LayoutViewExample.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(person pm)
        {
            string value = "ID: " + Convert.ToString(pm.id)
                + "<br />First Name: " + pm.fname
                + "<br />Last Name: " + pm.lname
                + "<br />Department Name: " + pm.dname +"<br/>"+
                 "Salary details"+ Convert.ToString(pm.sal);

            string s = "$('#output').html('" + value + "');";
            return JavaScript(s);
        }
    }
}