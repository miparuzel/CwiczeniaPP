using System;
using System.Drawing;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[10, 10];
            int number = 1;
            for (int i = 0; i < 10; i++)
            {
                if (i%2 == 0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        table[i, j] = number;
                        number++;
                    }
                }
                else
                {
                    for (int j = 9; j >= 0; j--)
                    {
                        table[i, j] = number;
                        number++;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }   
        }
    }
}

