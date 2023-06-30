
namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[10, 10];
            int number = 1;
            int rowstart = 0;
            int rowend = 9;
            int columnstart = 0;
            int columnend = 9;
            while (number <= 100) 
            {
                for (int i = columnstart; i <= columnend; i++)
                {
                    table[rowstart, i] = number;
                    number++;
                }
                rowstart++;
                for (int i = rowstart; i <= rowend; i++)
                {
                    table[i, columnend] = number;
                    number++;
                }
                columnend--;
                for (int i = columnend; i >= columnstart; i--)
                {
                    table[rowend, i] = number;
                    number++;
                }
                rowend--;
                for (int i = rowend; i >= rowstart; i--)
                {
                    table[i, columnstart] = number;
                    number++;
                }
                columnstart++;
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
