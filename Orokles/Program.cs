using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember bela = new Ember("Béla");
            Console.WriteLine(bela.Bemutatkozik());

            Tanulo peti = new Tanulo("Peti");
            peti.Osztaly = "1.B";
            Console.WriteLine(peti.Bemutatkozik());
            

            Console.ReadKey();
        }
    }
}
