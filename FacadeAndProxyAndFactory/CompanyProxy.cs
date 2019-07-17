using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeAndProxy
{
    class CompanyProxy : ClientProxy
    {
        public CompanyProxy()
        {
            this.company = new FlightSystemFacade();
        }

        public ICompany company { get; set; }

        public void CreateFlight()
        {
            this.company.CreateFlight();
        }

        public void RemoveFlight()
        {
            this.company.RemoveFlight();
        }
    }
}
