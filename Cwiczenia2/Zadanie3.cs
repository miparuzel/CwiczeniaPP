using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;
            int countn=1;
            int countk = 1;
            int nf = 1;
            int kf = 1;
            while (n < 5)
            {
                Console.WriteLine("Podaj n, n nie może być mniejsze od 5");
                n = int.Parse(Console.ReadLine());
            }
            while (k < 5)
            {
                Console.WriteLine("Podaj k, k nie może być mniejsze od 5");
            k = int.Parse(Console.ReadLine());
            }
            do
            {
                nf = nf * countn;
                countn++;
            } while (countn < n+1);
            do
            {
                kf = kf * countk;
                countk++;
            } while (countk < k+1);
            Console.WriteLine("M wynosi:" + ((nf-kf)/kf));
        }
    }
}
