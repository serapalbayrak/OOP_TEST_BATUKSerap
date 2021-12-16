using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPTestReis.Models
{
    public class Cruise : Reis
    {
        private const double CruisePrijsExtraDagKost = 10;

        public Cruise(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen, bool vip) : base(terugDatum, vertrekDatum, aantalPersonen)
        {
            VIP = vip;
        }
         private bool VIP { get; set; }
        private  double basisPrijs;

        public override double BerekenPrijs()
        {
            if (VIP)
            {
                return basisPrijs;
            }
            else
            {
                return basisPrijs * 1.5;
            }

        }
        
    }
}
