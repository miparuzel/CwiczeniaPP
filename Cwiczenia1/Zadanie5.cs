using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby");
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("Większa liczba to "+a);
            }
            if (b>a)
            {
                Console.WriteLine("Większa liczba to " + b);
            }
            if (b == a)
            {
                Console.WriteLine("Liczby są równe");
            }
        }
    }
}
