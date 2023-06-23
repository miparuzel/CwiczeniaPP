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
            for (int i = 0; i <= size - 1; i++)
            {
                table[i] = rnd.Next(100);
            }
            for (int j = 0; j <= size - 1; j++)
            {
                for (int i = 0; i < size - j-1; i++)
                {
                    if (table[i] > table[i + 1])
                        (table[i], table[i + 1]) = (table[i + 1], table[i]);
                };
            }
            for(int i = 0; i <= size -1; i++)
                Console.Write(table[i]+ " ");
        }
    }
}
