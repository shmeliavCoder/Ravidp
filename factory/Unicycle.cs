using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryRavid
{
    public class Unicycle : Vehicle
    {
        protected string drivingWheelHeater;

        public Unicycle(string model, float cylinder, string color, int numberOfWheels, string drivingWheelHeater) : base(model, cylinder, color, numberOfWheels)
        {
            this.drivingWheelHeater = drivingWheelHeater;
        }

        public override string ToString()
        {
            return "UNICYCLE " + base.ToString() + $" {drivingWheelHeater}";
        }
    }
}
