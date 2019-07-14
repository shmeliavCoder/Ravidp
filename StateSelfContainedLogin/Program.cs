using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Init(new NewLoginState(context));

            context.Login("ravid");
            context.Logout();
            context.Logout();
            context.Login("asd");
            context.Login("asd");
            context.Login("asd");
            context.Login("asd");
        }
    }
}
