using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    class Context
    {
        public ILoginState State { get; set; }

        public void Login(string pass)
        {
            State.Login(pass);
        }

        public void Logout()
        {
            State.Logout();
        }

        public void Init(ILoginState state)
        {
            State = state;
        }
    }
}
