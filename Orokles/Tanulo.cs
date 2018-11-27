using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Tanulo: Ember
    {

        public string Osztaly { get; set; } 

        public Tanulo(string nev): base(nev)
        {
            
        }

        public override string Bemutatkozik()
        {
            return base.Bemutatkozik() + " A " + Osztaly + "-be járok";
        }
    }
}
