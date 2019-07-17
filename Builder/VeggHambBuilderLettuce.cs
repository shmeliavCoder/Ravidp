﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VeggHambBuilderLettuce : VeggHamburgerBuilder
    {
        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Lettuces");
        }

    }
}
