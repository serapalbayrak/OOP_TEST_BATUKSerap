using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTestReis.Models
{
    public class Adres
    {
        private int postcode;
        public string Gemente { get; set; }
        public string HuisNr { get; set; }

        public int PostCode
        {
            get
            { 
                return PostCode;
            }
            set
            {
                postcode = value;
            }
        }
        public string Straat { get; set; }
    }
}
