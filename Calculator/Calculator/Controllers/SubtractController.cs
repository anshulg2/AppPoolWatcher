using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calculator.Controllers
{
    public class SubtractController : ApiController
    {
        // GET: api/Subtract
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Subtract/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Subtract
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Subtract/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Subtract/5
        public void Delete(int id)
        {
        }
    }
}
