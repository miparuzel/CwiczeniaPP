
namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną");
            double size = 0;
            Boolean incorrect = true;
            while (incorrect) 
            {
                size = double.Parse(Console.ReadLine());
                if (size > 0 && size % 1 == 0)
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("To nie jest liczba naturalna. Podaj liczbę naturalną");
                }

            }
            int size1 = Convert.ToInt32(size);

            int[,] table1 = new int[size1, size1];
            int number1 = 1;
            for (int i = 0; i < size1; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < size1; j++)
                    {
                        table1[i, j] = number1;
                        number1++;
                    }
                }
                else
                {
                    for (int j = size1-1; j >= 0; j--)
                    {
                        table1[i, j] = number1;
                        number1++;
                    }
                }
            }
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size1; j++)
                {
                    Console.Write(table1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] table = new int[size1, size1];
            int number = 1;
            int rowstart = 0;
            int rowend = size1-1;
            int columnstart = 0;
            int columnend = size1-1;
            while (number <= size* size)
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
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j <size1; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

