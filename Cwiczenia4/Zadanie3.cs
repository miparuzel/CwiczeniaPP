using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość wierszy");
            int rows = int.Parse(Console.ReadLine());
            for(int i = 1; i <= rows;i++)
            {
                for(int j = 1; j <= rows-i;j++)
                {
                    Console.Write(" ");
                }
                int width = 1;
                for (int s = 1; s < i; s++)
                    width = width + 2;
                for(int k = 1; k <= width;k++)
                    Console.Write("+");
                Console.WriteLine();
            }
        }
    }
}
