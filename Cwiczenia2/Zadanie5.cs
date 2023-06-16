using System;

namespace Average
{
    class Program
    {
        public static double silnia(double i)
            {
            int ns = 1;
            for(int j = 1; j <= i; j++)
            {
                ns *= j;
            }
            return ns;
        }
        public static double suma(double x, double i)
        {
            double wynik = 0;
            for (double j = 0; j <= i; ++j)
            {
                wynik = +(Math.Pow(x, j) / silnia(j));
            }
            return wynik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj x");
            double x =double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj n");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Wynik to "+ suma(x,i));
            
        }
    }
}