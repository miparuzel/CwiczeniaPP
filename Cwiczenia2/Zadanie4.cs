using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double odset=0;
            double profit = 0;
            Console.WriteLine("Podaj kwotę");
            double kwota = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj oprocentowanie");
            double proc = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę miesięcy");
            int mies = int.Parse(Console.ReadLine());
            while (mies > 0) 
            {
                odset = kwota * ((proc / 12) / 100);
                kwota = kwota + odset;
                profit = profit + odset;
                mies--;
            }
            double zysk = Math.Round(profit) - Math.Ceiling(profit*0.19);
            Console.WriteLine("Zarobisz " + zysk);
        }
    }
}

