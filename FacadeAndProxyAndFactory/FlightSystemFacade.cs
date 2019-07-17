using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeAndProxy
{
    class FlightSystemFacade : IAdmin, ICustomer, ICompany
    {
        private FlightDAO flightDao = new FlightDAO();
        public void BuyTickets()
        {
            this.flightDao.BuyTicket();
        }

        public void CreateCompany()
        {
            this.flightDao.InsertCompany();
        }

        public void CreateCustomer()
        {
            this.flightDao.InsertedCustomer();
        }

        public void CreateFlight()
        {
            this.flightDao.InsertFlight();
        }

        public void RemoveFlight()
        {
            this.flightDao.RemoveFlight();
        }

        public void ShowTickets()
        {
            this.flightDao.ShowTicket();
        }
    }
}
