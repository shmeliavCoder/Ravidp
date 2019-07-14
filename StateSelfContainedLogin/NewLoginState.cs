using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    class NewLoginState : LoginState
    {
        public NewLoginState(Context context) : base(context)
        {
        }

        public override void Login(string pass)
        {
            if (pass.Equals("ravid"))
            {
                context.State = new LoggedInState(this.context);
                Console.WriteLine("Logged in");
            }
            else
            {
                Console.WriteLine("Wrong pass");
                context.State = new LoginFailedState(this.context);
            }
        }
    }
}
