using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Podaj rozmiar tablicy");
            int size = int.Parse(Console.ReadLine());
            int[] table = new int[size];
            for (int i = 0; i <= size-1; i++)
            {
                table[i] = rnd.Next(100);
            }
            for (int i = size-1; i >= 0; i--)
            {
                Console.WriteLine(table[i]);
            }
        }
    }
}