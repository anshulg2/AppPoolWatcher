using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common;
using Calculator.Data;


namespace Calculator.Logic.Operation
{
    public class SumOperation:IOperation
    {
        private ILogger _logger;
        private ISumRepository _sumRepository;
        public SumOperation(ILogger logger, ISumRepository repository)
        {
            _logger = logger;
            _sumRepository = repository;
        }

        public BaseResponse Execute(BaseRequest request)
        {
            var sumRequest = request as SumRequest;
            _logger.LogError("I am calling Sum");
            if (sumRequest is null)
            {
                _logger.LogError("Sum Failed", new ArgumentNullException()); 
                throw new ArgumentNullException("sumRequest");
            }

            var result = _sumRepository.Sum(sumRequest.a, sumRequest.b);

            return new SumResponse() {Result = result};
        }
    }
}
