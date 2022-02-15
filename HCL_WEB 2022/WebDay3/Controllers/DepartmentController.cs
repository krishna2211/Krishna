using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDay3.Models;
namespace WebDay3.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            Dept dobj = new Dept { deptno = 10, dname = "MKTG", location = "MUMBAI" };
            Dept dobj1 = new Dept { deptno = 20, dname = "Sales", location = "Pune" };
            Dept dobj2 = new Dept { deptno = 30, dname = "Admin", location = "Chennai" };
            IList<Dept> dd = new List<Dept>()
            {dobj,dobj1,dobj2};
            return View(dd);
        }
            
          
    }
}