using System;

namespace ParOuImparURI1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x % 2==0 && x > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }

                if (x % 2 != 0 && x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }

                if (x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }

                if (x % 2 != 0 && x < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
