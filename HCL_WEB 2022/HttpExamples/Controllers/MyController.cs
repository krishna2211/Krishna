using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpExamples.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public ContentResult Index()
        //{
        //    return Content("I am working on various return types of action method");
        //}
        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.google.co.in");
        //}
        //public EmptyResult Index()
        //{
        //    ViewBag.Itemlist = "Good Afternoon mvc session is on";
        //    return new EmptyResult();
        //}
        //public JsonResult Index()
        //{
        //    Emp eobj = new Emp { empno = 100, ename = "James" };
        //    return Json(eobj, JsonRequestBehavior.AllowGet);
        //}
        //public class Emp
        //{
        //    public int empno { get; set; }
        //    public string ename { get; set; }
        //}
        [HttpGet]
        public FileResult Download()
        {
            byte[] filebytes = System.IO.File.ReadAllBytes(@"d:\code.txt");
            string filename = "code.txt";
            return File(filebytes, System.Net.Mime.MediaTypeNames.Application.Octet,
                filename);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}