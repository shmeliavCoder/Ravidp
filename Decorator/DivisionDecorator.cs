using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DivisionDecorator : BaseFoemulaDecorator
    {
        public DivisionDecorator(IFormula formu) : base(formu)
        {
        }

        public override string getFoemula()
        {
            return this.Formula.getFoemula() + "/5";
        }
    }
}
