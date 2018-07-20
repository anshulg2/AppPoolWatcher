using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Common
{
    public class SubtractRequest:BaseRequest
    {
        public decimal a { get; set; }

        public decimal b { get; set; }
    }
}
