using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class BaseFoemulaDecorator : IFormula
    {
        public IFormula Formula { set; get; }
        
        public abstract string getFoemula();

        public BaseFoemulaDecorator(IFormula formu)
        {
            this.Formula = formu;
        }
    }
}
