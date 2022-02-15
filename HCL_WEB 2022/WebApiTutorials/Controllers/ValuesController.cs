using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTutorials.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        static List<string> books = new List<string>()
        {
        "Programming in c#", "Asp.net unleashed",
            "java in 21 days" };
        public IEnumerable<string> Get()
        {
            return books;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return books[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
