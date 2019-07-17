using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormula formula = new DivisionDecorator(new MultiplyFiveDecorator(new Formula(10)));

            Console.WriteLine(formula.getFoemula());
        }
    }
}
