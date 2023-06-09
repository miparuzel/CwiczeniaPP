using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj x");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj y");
            Double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj r");
            Double r = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(r, 2)>= Math.Pow(x, 2)+ Math.Pow(y, 2))
            {
                Console.WriteLine("Punkt P leży w obrębie koła");
            }
            if (Math.Pow(r, 2) < Math.Pow(x, 2) + Math.Pow(y, 2))
            {
                Console.WriteLine("Punkt P nie leży w obrębie koła");
            }

        }
    }
}
