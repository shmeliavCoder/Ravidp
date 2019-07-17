using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeAndProxy
{
    public class ProxyFactory
    {
        private Dictionary<string, ClientProxy> dictionary = new Dictionary<string, ClientProxy>();

        public ProxyFactory()
        {
            this.dictionary.Add("ravid", new AdminProxy());
            this.dictionary.Add("har", new CustomerProxy());
            this.dictionary.Add("asd", new CompanyProxy());
        }

        public ClientProxy Login(string username)
        {
            ClientProxy proxy;

            dictionary.TryGetValue(username, out proxy);

            if (proxy == null)
            {
                throw new Exception("No such client type");
            }

            return dictionary[username];
        }
    }
}
