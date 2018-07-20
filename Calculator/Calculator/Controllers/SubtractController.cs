using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using Calculator.Common;
using Calculator.Logic;

namespace Calculator.Controllers
{
    public class SubtractController : ApiController
    {
        private IOperationFactory _operationFactory;

        public SubtractController(IOperationFactory factory)
        {
            _operationFactory = factory;
        }
        // POST: api/Subtract
        public SubtractResponse Post([FromBody]SubtractRequest request)
        {
            var result = _operationFactory.Create(request).Execute(request);

            return (SubtractResponse) result;
        }
        
    }
}
