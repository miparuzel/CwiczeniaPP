using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pole koła");
            Double pole = Convert.ToDouble(Console.ReadLine());
            Double promien = Math.Sqrt(pole/3.14);
            Double obwod = promien*2*3.14;
            Console.WriteLine("Obwód koła to " + obwod);
        }
    }
}
