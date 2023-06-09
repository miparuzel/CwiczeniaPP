using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą a");
            Int64 a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Podaj liczbę całkowitą b");
            Int64 b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Podaj liczbę całkowitą c");
            Int64 c = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Podaj liczbę całkowitą d");
            Int64 d = Convert.ToInt64(Console.ReadLine());
            if (b==0 || d==0)
            {
                Console.WriteLine("Brak rozwiązania");
            }
            else
            {
                Int64 aa = a * d;
                Int64 cc = c * b;
                Int64 x = aa + cc;
                Int64 y = b * d;
                Console.WriteLine("Licznik wynosi " + x);
                Console.WriteLine("Mianownik wynosi " + y);
            }
        }
    }
}