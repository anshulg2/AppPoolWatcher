using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Calculator.Common;
using Calculator.Logic;

namespace Calculator.Controllers
{
    public class SumController : ApiController
    {
        private IOperationFactory _operationFactory;

        public SumController(IOperationFactory factory)
        {
            _operationFactory = factory;
        }
        
        // POST: api/Sum
        public SumResponse Post([FromBody]SumRequest request)
        {
            var result = _operationFactory.Create(request).Execute(request);

            return (SumResponse)result;
           // return new SumResponse();
        }
    }
}
