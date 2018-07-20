using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common;
using Calculator.Data;

namespace Calculator.Logic.Operation
{
    public class SubtractOperation:IOperation
    {
        public ILogger _logger;
        public ISubtractRepository _subtractRepository;

        public SubtractOperation(ILogger logger, ISubtractRepository subtractRepository)
        {
            _logger = logger;
            _subtractRepository = subtractRepository;
        }
        public BaseResponse Execute(BaseRequest request)
        {
            var subtractRequest = request as SubtractRequest;

            if (subtractRequest == null)
            {
                _logger.LogError("Subtract Failed");
                throw new ArgumentException("subtractRequest");
            }

            var result = _subtractRepository.Subtract(subtractRequest.a, subtractRequest.b);

            return new SubtractResponse() {Result = result};
        }
    }
}
