using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeAndProxy
{
    public class CustomerProxy : ClientProxy
    {

        public ICustomer Customer {get; set;}

        public CustomerProxy()
        {
            this.Customer = new FlightSystemFacade();
        }

        public void BuyTickets()
        {
            this.Customer.BuyTickets();
        }

        public void ShowTickets()
        {
            this.Customer.ShowTickets();
        }
    }
}
