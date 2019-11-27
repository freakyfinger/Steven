using System;

namespace Steven
{
    class Program
    {
        static void Main(string[] args)
        {
            steven(100);

            Console.ReadLine();
        }

        static void steven(int x)
        {
            for(int j = 1; j <= x; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("It's even Steven");
                }
                if (j % 2 == 1)
                {
                    Console.WriteLine("It's odd Todd");
                }
            }
        }
    }
}
