using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    class LoginFailedState : LoginState
    {
        private int timesToLock = 1;

        public LoginFailedState(Context context) : base(context)
        {
        }

        public override void Login(string pass)
        {
            if (pass.Equals("ravid"))
            {
                Console.WriteLine("Logged in");
                context.State = new LoggedInState(this.context);
            }
            else if (this.timesToLock == 0)
            {
                Console.WriteLine("You are now locked");
                context.State = new LockedLoginState(this.context);
            }
            else
            {
                Console.WriteLine("Wrong pass.");
                this.timesToLock--;
            }
        }
    }
}
