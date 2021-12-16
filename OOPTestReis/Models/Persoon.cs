using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTestReis.Models
{
    public class Persoon
    {
        public string FamilieNaam { get; set; }
       
        public string VoorNaam { get; set; }
        private readonly string _naam;

        public Adres Adres()
        {
            return Naam;
        }
    }
}
