using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    public class Ember
    {
        public string Nev { get; private set; }

        public Ember(string nev) { Nev = nev; }

        public virtual string Bemutatkozik() { return "Szia! " + Nev + " vagyok!"; }
    }
}
