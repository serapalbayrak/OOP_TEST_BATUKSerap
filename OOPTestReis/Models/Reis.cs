using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTestReis.Models
{
    public abstract class Reis
    {
        public Reis(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen)
        {
            TerugkeerDatum = terugDatum;
            VertrekDatum = vertrekDatum;
            AantalPersonen = aantalPersonen;
        }
        private const double BASISDAGPRIJS = 40;
        public int AantalDagen
        {
            get
            {
                TimeSpan ts = TerugkeerDatum - VertrekDatum;
                return ts.Days;
            }
        }
        public int AantalPersonen { get; set; }
        public DateTime TerugkeerDatum
        {
            get { return TerugkeerDatum; }
            set
            {
                if (AantalDagen <= 0)
                {
                    throw new Exception("it is not same day.  1 day stay .");
                }
                TerugkeerDatum = value;
            }
        }
        public DateTime VertrekDatum
        {
            get { return VertrekDatum; }
            set
            {
                if (VertrekDatum < DateTime.Now)
                {
                    throw new Exception("It is past day");
                }
                VertrekDatum = value;
            }
        }
        public virtual double BerekenPrijs()
        {
            return BASISDAGPRIJS * AantalDagen;
        }
    }
}