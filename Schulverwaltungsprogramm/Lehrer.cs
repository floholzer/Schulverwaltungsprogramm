using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulverwaltungsprogramm
{
    public class Lehrer:Person
    {
        public string personalNr { get; set; }
        public string Hauptfach { get; set; }

        public override string Typ => "Lehrer";
    }
}
