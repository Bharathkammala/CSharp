using System;

namespace logics
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                Console.WriteLine(new string('*', 2 * i + 1));

            }
        }
    }
}

