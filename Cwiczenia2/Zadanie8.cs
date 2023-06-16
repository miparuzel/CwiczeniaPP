using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ul = 21;
            int ll = 1;
            Console.WriteLine("Jeżeli liczba którą podam jest:");
            Console.WriteLine("Mniejsza od szukanej liczby wpisz liczbę ujemną");
            Console.WriteLine("Większa od szukanej liczby wpisz liczbę dodatnią");
            Console.WriteLine("Prawidłowa wpisz 0");
            int n = rnd.Next(ll, ul);
            Console.WriteLine("Czy to " + n);
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                if (a > 0)
                {
                    ul = n;
                    n = rnd.Next(ll, ul);
                    Console.WriteLine("Czy to " + n);
                    a = int.Parse(Console.ReadLine());
                }
                if (a < 0)
                {
                    ll = n;
                    n = rnd.Next(ll, ul);
                    Console.WriteLine("Czy to " + n);
                    a = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Zgadłem to " + n);
        }
    }
}
