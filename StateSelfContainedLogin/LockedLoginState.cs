using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    class LockedLoginState : LoginState
    {
        public LockedLoginState(Context context) : base(context)
        {
        }

        public override void Login(string pass)
        {
            Console.WriteLine("Locked. cannot login");
        }

        public override void Logout()
        {
            Console.WriteLine("Locked. cannot logout");
        }
    }
}
