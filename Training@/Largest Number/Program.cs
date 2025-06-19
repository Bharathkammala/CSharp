using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            decimal i = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter second number");
            decimal j = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter third number");
            decimal k = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Math.Max(i, Math.Max(j, k));
        }
    }
}
