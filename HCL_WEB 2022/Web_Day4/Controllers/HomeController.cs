using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Day4.Models;
namespace Web_Day4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeBuisnessLayer employeebl = new EmployeeBuisnessLayer();
            Employee e = employeebl.GetEmployeeDetails(100);
            ViewData["Employee"] = e;
            ViewData["Header"] = "Employee Details Information";
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
    }
}