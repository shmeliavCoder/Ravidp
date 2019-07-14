using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    abstract class LoginState : ILoginState
    {

        protected Context context;

        public LoginState(Context context)
        {
            this.context = context;
        }

        public abstract void Login(string pass);

        public virtual void Logout()
        {
            context.State = new NewLoginState(this.context);
            Console.WriteLine("Logged out");
        }
    }
}
