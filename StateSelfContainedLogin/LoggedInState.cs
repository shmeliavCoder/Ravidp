using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    class LoggedInState : LoginState
    {
        public LoggedInState(Context context) : base(context)
        {
        }

        public override void Login(string pass)
        {
            Console.WriteLine("Already logged in");
        }
    }
}
