using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HamburgerFactory
    {
        public Hamburger getHamburger(string hamburgerName)
        {
            HamburgerBuilder builder = null;

            switch (hamburgerName)
            {
                case ("Crispy Chicken"):
                    {
                        builder = new CrispyChickenBuilder();
                        break;
                    }
                case ("Crispy Chicken With Tomato"):
                    {
                        builder = new CrispyChickenBuilderTomato();
                        break;
                    }
                case ("Veggy Burger"):
                    {
                        builder = new VeggHamburgerBuilder();
                        break;
                    }
                case ("Veggy Burger With Lettuce"):
                    {
                        builder = new VeggHambBuilderLettuce();
                        break;
                    }
            }

            return builder.GetHamburger();
        }
    }
    
}
