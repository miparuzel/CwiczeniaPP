using System;
using System.Drawing;

namespace Average
{
    class Program
    {
        static void time(Int32 input)
        {
            int hour = input / 3600;
            int min = (input-hour*3600)/60;
            int sec = input % 60;
            int hour1 = hour / 10;
            int hour2 = hour % 10;
            int min1 = min / 10;
            int min2 = min % 10;
            int sec1 = sec / 10;
            int sec2 = sec % 10;
            Console.WriteLine(hour1+ "" + hour2 + ":" + min1 + min2 + ":" + sec1 + sec2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj czas jaki upłynął od godziny 00:00:00 w sekundach");
            time(Int32.Parse(Console.ReadLine()));
        }
    }
}

