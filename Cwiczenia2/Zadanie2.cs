
using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());
            int a = 0; int b = 1;
            Console.Write(a + " " + b);
            while (n>1) 
            {
                if (a<b)
                {
                    a = a + b;
                    Console.Write(" " + a);
                }
                else
                {
                    b = a + b;
                    Console.Write(" " + b);
                }
                n--;
            }
        }
    }
}
