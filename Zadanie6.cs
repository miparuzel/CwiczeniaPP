using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj boki trójkąta");
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());
            Double c = Convert.ToDouble(Console.ReadLine());
            if (a==b && b==c)
            {
                Console.WriteLine("To jest trójkąt równoboczny");
            }
            else
            {
                Console.WriteLine("To nie jest trójkąt równoboczny");
            }
        }
    }
}