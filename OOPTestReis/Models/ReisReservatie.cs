using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTestReis.Models
{
    public class ReisReservatie:ILoggable

    {

        public LogMessage logMessage { get; set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public ReisBureau ReisBureau { get; set; }

        public ReisReservatie(Reis reis, ReisBureau reisbureau, Persoon persoon)
        {
            Reis = reis;
            ReisBureau = reisbureau;
            Persoon = persoon;
            LoggerService.AddLogMessage(LogMessage);
        }

     



        public LogMessage LogMessage
        {
            get
            {
                return new LogMessage($" door {Persoon.Naam}via reisbureau{reisbureau}");

            }


        }
    }
}
