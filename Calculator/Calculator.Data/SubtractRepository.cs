using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data
{
    public interface ISubtractRepository
    {
        decimal Subtract(decimal a, decimal b);
    }
    public class SubtractRepository:ISubtractRepository
    {
        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;//This should Call Database to get the response
        }
    }
}
