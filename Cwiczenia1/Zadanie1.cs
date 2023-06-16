
using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 3 liczby");
            Double liczba1 = Convert.ToDouble(Console.ReadLine());
            Double liczba2 = Convert.ToDouble(Console.ReadLine());
            Double liczba3 = Convert.ToDouble(Console.ReadLine());
            Double suma =liczba1+liczba2 + liczba3;
            Double srednia = suma / 3;
            Console.WriteLine("Średnia arytmetyczna to " + srednia);
        }
    }
}
