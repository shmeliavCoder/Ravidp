using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerBase error = new ErrorLoggerHandler();
            LoggerBase warn = new WarningLoggerHandler();
            LoggerBase info = new InfoLoggerHandler();
            LoggerBase debug = new DebugLoggerHandler();

            error.Next = warn;
            warn.Next = info;
            info.Next = debug;

            error.Handle("Ravid is the king", 1);
            error.Handle("Ravid is the king", 2);
            error.Handle("Ravid is the king", 3);
            error.Handle("Ravid is the king", 4);

        }
    }
}
