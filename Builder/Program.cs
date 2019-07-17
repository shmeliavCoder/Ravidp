using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            HamburgerFactory factory = new HamburgerFactory();
            Hamburger crispyChicken = factory.getHamburger("Crispy Chicken");
            Hamburger crispyChickenWithTamato = factory.getHamburger("Crispy Chicken With Tomato");
            Hamburger VeggyBurger = factory.getHamburger("Veggy Burger");
            Hamburger VeggyBurgerWithLettuce = factory.getHamburger("Veggy Burger With Lettuce");

            Console.WriteLine(crispyChicken);

        }
    }
}
