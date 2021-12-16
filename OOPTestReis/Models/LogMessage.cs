using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTestReis.Models
{
    public class LogMessage:ILoggable
    {

        public int GeneerId;

        public string BoodSchap { get, private set; }

        public int ID { get; private set; }

        public LogMessage logMessage => throw new NotImplementedException();

        private int GeneerID()
        {
        int maxID = 0;
        foreach (LogMessage message in LoggerService.logs)
        {
            if (maxID<=message.ID)
            {
                maxID = message.ID;
            }
        }
        return (maxID + 1);
    }
        public void GenereerID()
        {

        }
        LogMessage()
        {


        }
            

    }
}
