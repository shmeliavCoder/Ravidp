using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CrispyChickenBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Regular");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("Fried Chicken Breast");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("Maio");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Letuce");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 60 ILS");
        }
    }
}
