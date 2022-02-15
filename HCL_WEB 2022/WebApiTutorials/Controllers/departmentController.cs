using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTutorials.Models;
namespace WebApiTutorials.Controllers
{
    public class departmentController : ApiController
    {
        dept[] dobj = new dept[]
       {
            new dept{deptno=10,dname="Marketing",loc="UK"},
            new dept{deptno=20,dname="Admin",loc="US"},
            new dept{deptno=30,dname="SAP",loc="Columbo"}
        };
        public IEnumerable<dept> Get()
        {
            return dobj;
        }
        // GET api/values/5
        public dept GetDept(int dd)
        {
            var res = dobj.FirstOrDefault(e => e.deptno == dd);
            if (res == null)
            {
                throw new HttpResponseException(Request.CreateResponse
                    (HttpStatusCode.NotFound));
            }
            return res;
        }
    }
}
