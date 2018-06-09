using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Calculator.Common;
using Calculator.Logic.Operation;

namespace Calculator.Logic
{
    public interface IOperationFactory
    {
        IOperation Create(BaseRequest request);
    }
    public class OperationFactory:IOperationFactory
    {
        private ILogger _logger;

        public OperationFactory(ILogger logger)
        {
            _logger = logger;
        }

        public IOperation Create(BaseRequest request)
        {
            if(request is SumRequest)
                return  new SumOperation(_logger);

            throw new Exception("Invalid Operation");
        }
    }
}
