using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj numer działania");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Int64 d = Convert.ToInt64(Console.ReadLine());
            if (d==1)
            {
                Console.WriteLine(a+"+"+b+"="+(a+b));
            }
            if (d == 2)
            {
                Console.WriteLine(a + "-" + b + "=" + (a - b));
            }
            if (d == 3)
            {
                Console.WriteLine(a + "*" + b + "=" + (a * b));
            }
            if (d == 4 && b==0)
            {
                Console.WriteLine(a + "/" + b);
            }
            if (d == 4 && b != 0)
            {
                Console.WriteLine(a + "/" + b + "=" + (a / b));
            }
        }
    }
}
