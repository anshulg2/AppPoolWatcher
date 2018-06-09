using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Common
{
    public class BaseResponse
    {
        public Guid RequestId { get; set; }
    }
}
