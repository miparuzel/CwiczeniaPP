using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int low = 101;
            int high = 0;
            Console.WriteLine("Podaj rozmiar tablicy");
            int size = int.Parse(Console.ReadLine());
            int[] table = new int[size];
            for (int i = 0; i <= size - 1; i++)
            {
                table[i] = rnd.Next(100);
                if (low > table[i])
                    low = table[i];
                if (high < table[i])
                    high = table[i];
            }
            Console.WriteLine();
            Console.WriteLine("Największy element tablicy to: " + high);
            Console.WriteLine("Najmniejszy element tablicy to: " + low);
        }
    }
}

