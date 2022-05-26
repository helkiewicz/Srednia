using System;

namespace Srednia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę 1:");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe 2:");
            int liczba2 = int.Parse(Console.ReadLine());

            wyliczSredniaProceduralnie(liczba1, liczba2);

            double wynik = wyliczSredniaFunkcyjnie(liczba1, liczba2);
            Console.WriteLine("Średnia to: {0}", wynik);


            Console.ReadKey();
        }

        static void wyliczSredniaProceduralnie(double liczba1, double liczba2)
        {
            double srednia = (liczba1 + liczba2) / 2;
            Console.WriteLine("Średnia to: {0}", srednia);
        }

        static Double wyliczSredniaFunkcyjnie(double liczba1, double liczba2)
        {
            double srednia = (liczba1 + liczba2) / 2;
            return srednia;
        }
    }
}
