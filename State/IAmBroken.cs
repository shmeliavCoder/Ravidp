using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class IAmBroken : ILightState
    {
        public ILightState Fix()
        {
            Console.WriteLine("Fixed, off");
            return new IAmOff();
        }

        public ILightState TurnOff()
        {
            Console.WriteLine("BROKEN do nothing");
            return this;
        }

        public ILightState TurnOn()
        {
            Console.WriteLine("BROKEN do nothing");
            return this;
        }
    }
}
