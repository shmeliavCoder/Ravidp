using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeAndProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory proxyFactory = new ProxyFactory();

            ClientProxy admin = proxyFactory.Login("ravid");
            ((AdminProxy)admin).CreateCustomer();

            ClientProxy customer = proxyFactory.Login("har");
            ((CustomerProxy)customer).ShowTickets();

            ClientProxy company = proxyFactory.Login("asd");
            ((CompanyProxy)company).RemoveFlight();
        }
    }
}
