using System;

namespace Zaddom
{
    class Program
    {

        static void prime(int n)
        {
            for (int p = 2; p < n; p++)
            {
                bool check = false;
                for (int i = 2; i < p; i++)
                {
                    if (p % i == 0)
                    {
                        check = true;
                    }
                }
                if (check == false)
                {
                    Console.WriteLine(p);
                }
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbę: ");
            int input = int.Parse(Console.ReadLine());
            prime(input);

        }
    }
}