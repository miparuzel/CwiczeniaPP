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
            Console.WriteLine();
            for (int i = 0; i <= size - 1; i++)
            {
                int low = table[i];
                int pos = i;
                for (int j = i+1; j <= size -1; j++)
                {
                    if (low > table[j])
                    {
                        low = table[j];
                        pos = j;
                        table[pos] = table[i];
                        table[i] = low;
                    }
                    
                }
            }
            for (int i = 0; i <= size - 1; i++)
                Console.Write(table[i] + " ");
        }
    }
}

