using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Formula : IFormula
    {
        public int Number { get; set; }
        public Formula( int number)
        {
            this.Number = number;
        }

        public string getFoemula()
        {
            return this.Number.ToString();
        }
    }
}
