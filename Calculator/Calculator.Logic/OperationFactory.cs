using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Calculator.Common;
using Calculator.Data;
using Calculator.Logic.Operation;

namespace Calculator.Logic
{
    public abstract class IOperationFactory
    {
        public abstract IOperation Create(BaseRequest request);
    }

    public class OperationFactory:IOperationFactory
    {
        private ILogger _logger;
        private ISumRepository _sumRepository;
        private ISubtractRepository _subtractRepository;

        public OperationFactory(ILogger logger, ISumRepository sumRepository, ISubtractRepository subtractRepository)
        {
            _logger = logger;
            _sumRepository = sumRepository;
            _subtractRepository = subtractRepository;
        }

        public override IOperation Create(BaseRequest request)
        {
            if(request is SumRequest)
                return  new SumOperation(_logger, _sumRepository);
            else if(request is SubtractRequest)
            {
                return  new SubtractOperation(_logger, _subtractRepository);
            }

            throw new Exception("Invalid Operation");
        }
    }
}
