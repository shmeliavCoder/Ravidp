using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeAndProxy
{
    public class FlightDAO
    {
        public void BuyTicket()
        {
            Console.WriteLine("Bought ticket");
        }

        public void ShowTicket()
        {
            Console.WriteLine("Showed ticket");
        }

        public void InsertFlight()
        {
            Console.WriteLine("Inserted flight");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("Removed flight");
        }

        public void InsertCompany()
        {
            Console.WriteLine("Inserted company");
        }

        public void InsertedCustomer()
        {
            Console.WriteLine("Inserted customer");
        }
    }
}
