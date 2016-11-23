using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa
{
    class Produkt
    {
        public double cenaJednostkowa;
        public string nazwa;
        public int ilosc;
        public Produkt(string nazwa, double cenaJednostkowa, int ilosc)
        {
            this.nazwa=nazwa;
            this.cenaJednostkowa=cenaJednostkowa;
            this.ilosc=ilosc;
        }
        public Produkt()
        {
            
        }
    }
}
