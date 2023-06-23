using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile liczb pierwszych wypisać?");
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = 1; p<n; i++)
            {
                Boolean pierwsza = true;
                for (int d = 2; d<i; d++)
                {
                    if (i % d == 0) 
                    { 
                        pierwsza = false;
                    }
                }
                if (pierwsza==true)
                {
                    Console.WriteLine(i);
                    p++;
                }
            }
        }
    }
}
