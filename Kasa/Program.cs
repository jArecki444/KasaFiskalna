using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa
{
    class Program:Aplikacja
    {
        static void Main(string[] args)
        {
            Aplikacja a1 = new Aplikacja();
            a1.WczytajKlawisz();
            Produkt p1 = new Produkt("kielbasa",11,2);
            
            a1.WczytajKlawisz();
            a1.WczytajKlawisz();
            a1.WczytajKlawisz();
            a1.WczytajKlawisz();
        }
    }
}
