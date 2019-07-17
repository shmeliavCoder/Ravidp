using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CrispyChickenBuilderTomato : CrispyChickenBuilder
    {
        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato");
        }
    }
}
