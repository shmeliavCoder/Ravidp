using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    class InfoLoggerHandler : LoggerBase
    {
        public override void Handle(string message, int logLevel)
        {
            if (logLevel == 3)
            {
                Console.WriteLine($"INFO: {message}");
            }
            else
            {
                if (Next != null)
                    Next.Handle(message, logLevel);
            }
        }
    }
}
