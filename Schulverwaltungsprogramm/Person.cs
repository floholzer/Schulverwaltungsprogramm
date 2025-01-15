using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulverwaltungsprogramm
{
    public class Person
    {
        public string vorname { get; set; }
        public string nachname { get; set; }
        public DateTime geburtsdatum { get; set; }
        public string geschlecht { get; set; }

        // Virtuelle Eigenschaft
        public virtual string Typ => "Person";
    }
}
