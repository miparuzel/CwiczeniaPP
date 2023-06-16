using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj podstawę");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wykładnik");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            while (b>1) 
            {
                c = c * a;
                b--;
            }
            Console.WriteLine("Potęga wynosi: "+c);
        }
    }
}

