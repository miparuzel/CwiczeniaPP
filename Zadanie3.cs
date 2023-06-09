using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wagę w kilogramach");
            Double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach");
            Double height = Convert.ToDouble(Console.ReadLine());
            Double bmi = weight / Math.Pow(height,2);
            Console.WriteLine("BMI to " + bmi);
        }
    }
}
