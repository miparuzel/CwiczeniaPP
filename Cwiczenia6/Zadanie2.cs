using System;
using System.Drawing;

namespace Average
{
    class Program
    {
        static double odcinek(int x1, int y1, int x2, int y2)
        {
            int x = Math.Abs(x1 - x2);
            int y = Math.Abs(y1 - y2);
            Console.WriteLine(x + " " + y);
            double o = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return o;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj x punktu początkowego");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y punktu początkowego");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj x punktu końcowego");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y punktu końcowego");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Długość odcinka to "+ odcinek(x1, y1, x2, y2));
        }
    }
}

