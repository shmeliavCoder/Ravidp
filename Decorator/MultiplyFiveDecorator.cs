using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class MultiplyFiveDecorator : BaseFoemulaDecorator
    {
        public MultiplyFiveDecorator(IFormula formu) : base(formu)
        {
        }

        public override string getFoemula()
        {
            return this.Formula.getFoemula() + "*5";
        }
    }
}
