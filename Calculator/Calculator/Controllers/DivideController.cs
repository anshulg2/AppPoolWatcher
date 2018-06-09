using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calculator.Controllers
{
    public class DivideController : ApiController
    {
        // GET: api/Divide
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Divide/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Divide
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Divide/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Divide/5
        public void Delete(int id)
        {
        }
    }
}
