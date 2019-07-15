using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    class WarningLoggerHandler : LoggerBase
    {
        public override void Handle(string message, int logLevel)
        {
            if (logLevel == 2)
            {
                Console.WriteLine($"WARN: {message}");
            }
            else
            {
                if (Next != null)
                    Next.Handle(message, logLevel);
            }
        }
    }
}
