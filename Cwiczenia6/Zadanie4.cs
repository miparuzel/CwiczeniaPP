using System;
using System.Drawing;

namespace Average
{
    class Program
    {
        static void Compare(int[,] table, out int row1, out int row2)
        {
            row1 = 0;
            row2 = 0;
            int[] wynik= { 0, 0 };
            double min = -1;
            for (int i = 0; i <= 8; i++)
            {
                for (int j = i+1; j <= 9; j++)
                {
                    if (min>miara(table, i , j) || min<0)
                    {
                        min = miara(table, i, j);
                        row1 = i;
                        row2 = j;
                    }
                }
            }
           
        }
        static double miara(int[,] table, int i, int j)
        {
            double d = 0;
            for(int k = 0; k <= 4; k++)
            {
                d += Math.Pow(table[i,k] - table[j,k], 2);
            }
            return d;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] table = new int[10, 5];
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 4; j++)
                table[i,j] = rnd.Next(100);
            }
            Compare(table, out int row1, out int row2);
            Console.WriteLine("Dwa najbardziej zbliżone do siebie wiersze to " + row1 + " i " + row2) ;
        }
    }
}

