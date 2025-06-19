using System;
using System.Linq;


namespace Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter different numbers giving space ");
            string numbers = Console.ReadLine();
            string[] strnum = numbers.Split(' ');
            decimal[] i = new decimal[strnum.Length];
            for (int j = 0; j < strnum.Length; j++)
            {
                i[j] = Convert.ToDecimal(strnum[j]);
            }
            Console.WriteLine(i.Max());

        }
    }
}