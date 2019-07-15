using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    abstract class LoggerBase
    {
        public LoggerBase Next { set; get; }

        public abstract void Handle(string message, int logLevel);

        
    }
}
