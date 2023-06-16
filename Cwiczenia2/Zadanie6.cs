using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            Console.WriteLine("Podaj x");
            double x = double.Parse(Console.ReadLine());
            if (x == 1) 
            {
                Console.WriteLine(x + " jest silnią 0 i 1");
            }
            if (x != 1)
            {
                do
                {
                    i++;
                    j *= i;
                }
                while (x > j);
                if (x == j)
                {
                    Console.WriteLine(x + " jest silnią " + i);
                }
                else
                    Console.WriteLine(x + " nie jest silnią");
            }
        }
    }
}
