using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    public interface ILoginState
    {
        void Login(string pass);
        void Logout();
    }
}
