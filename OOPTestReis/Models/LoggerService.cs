using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPTestReis.Models
{
    public static class LoggerService
    {
        private static LogMessage[] logs;

        static LoggerService()
           {
            logs = new LogMessage[0];
        }

        public static LogMessage[] logs ()
        {
            get {

                return logs;
            }
            private set { 
                logs = value;
        }

        public static void AddLogMessage (LogMessage message)
        {
            Array.Resize(ref logs, logs.Length, +1);
            logs[logs.Length - 1] = message;

        }
    }
}
