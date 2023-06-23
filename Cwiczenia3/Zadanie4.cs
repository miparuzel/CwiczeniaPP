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
            for (int i = 1;i <= size - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (table[i] < table[j])
                    {
                        int mem = table[i];
                        for(int k = i-1; k >= j; k--)
                        {
                            table[k + 1] = table[k];
                        }
                        table[j] = mem;
                    }
                }

            }
            for (int i = 0; i <= size - 1; i++)
                Console.Write(table[i] + " ");
        }
    }
}