using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            double n = double.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i + " " + (n-i));
            }
        }
    }
}
