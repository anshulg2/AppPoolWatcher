using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common;

namespace Calculator.Logic
{
    public interface IOperation
    {
        BaseResponse Execute(BaseRequest request);
    }
}
