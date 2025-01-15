using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulverwaltungsprogramm
{
    public class Schueler:Person
    {
        public string klasse { get; set; }
        public int note { get; set; }

        public override string Typ => "Schüler";
    }
}
