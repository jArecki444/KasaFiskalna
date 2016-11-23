using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa
{
    class Aplikacja : Koszyk
    {
        public int klawisz;
        public void WypiszMenu()
        {
            Console.WriteLine("Dzień Dobry!\n");
            Console.WriteLine("Co Chcesz zrobić? Naciśnij odpowiedni klawisz.\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - dodaj produkt do koszyka");//dziala
            Console.WriteLine("2 - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("3 - pokaz zawartość koszyka");//dziala
            Console.WriteLine("4 - pokaz Sumę do zapłaty");
            Console.WriteLine("5 - skasuj produkt z listy (musisz znać wcześniej numer na liście");
            Console.WriteLine("6 - wydrukuj paragon");
            Console.WriteLine("7 - dodaj nowy koszyk");
            Console.WriteLine("8 - Zakończ program");
        }
        public void WczytajKlawisz()
        {
            
                WypiszMenu();
                klawisz = int.Parse(Console.ReadLine());
                WykonajDzialanie();
                Console.ReadKey();
        }
        public void WykonajDzialanie()
        {
            switch (klawisz)
            {
                case 1:
                    Console.WriteLine("Podaj nazwe produktu: ");
                    nazwa = Console.ReadLine();
                    Console.WriteLine("Podaj ilosc: ");
                    ilosc = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj Cene jednostkowa: ");
                    cenaJednostkowa = int.Parse(Console.ReadLine());
                    zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));
                    
                    Console.Clear();
                    break;
                case 3:
                    zakupy.Add(new Produkt("przykladowa kielbasa", 11, 2));//dodalem przykladowe pole do listy by szybciej sprawdzac czy dziala 
                    foreach (var element in zakupy)
                    {
                        Console.WriteLine("Nazwa: {0}\nCena: {1}\n Ilosc: {2}", element.nazwa, element.cenaJednostkowa, element.ilosc);
                    }
                    
                    break;
                case 4:
                    foreach (var element in zakupy)
                    {
                        Console.WriteLine("Nazwa: {0}\nCena: {1}\n Ilosc: {2}", element.nazwa, element.cenaJednostkowa, element.ilosc);
                        double suma = 0; 
                        suma =+ element.cenaJednostkowa * element.ilosc;
                        Console.WriteLine("Do zaplaty: {0}", suma);
                    }
                    Console.Clear();
                    break;
            }
        }
    }
}