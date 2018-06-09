using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common;

namespace Calculator.Logic.Operation
{
    public class SumOperation:IOperation
    {
        private ILogger _logger;

        public SumOperation(ILogger logger)
        {
            _logger = logger;
        }

        public BaseResponse Execute(BaseRequest request)
        {
            var sumRequest = request as SumRequest;
            if (sumRequest is null)
            {
                _logger.Log("Sum Failed"); 
                throw new ArgumentNullException("sumRequest");
            }

            return new SumResponse() {Result = sumRequest.a + sumRequest.b};
        }
    }
}
