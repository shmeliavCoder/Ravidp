using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    class DebugLoggerHandler : LoggerBase
    {
        public override void Handle(string message, int logLevel)
        {
            if (logLevel == 4)
            {
                Console.WriteLine($"DEBUG: {message}");
            }
            else
            {
                if (Next != null)
                    Next.Handle(message, logLevel);
            }
        }
    }
}
