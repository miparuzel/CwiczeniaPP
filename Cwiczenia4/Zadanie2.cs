using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int los1 = 0;
            int los2 = 0;
            Console.WriteLine("Ile liczb parzystych wypisać?");
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            for(int i = 0; p < n;)
            {
                int num = rnd.Next(-8, 9);
                los1++;
                if(num%2==0 && num != 0)
                {
                    if(p !=0)
                        Console.Write(", ");
                    Console.Write(num);
                    p++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Było "+ los1 + " losowań");
            Console.WriteLine();
            for (int i = 1; i<=n;i++)
            {
                int num = rnd.Next(-4, 5)*2;
                los2++;
                if (i != 1)
                    Console.Write(", ");
                Console.Write(num);
            }
            Console.WriteLine();
            Console.WriteLine("Było " + los2 + " losowań");
        }
    }
}

