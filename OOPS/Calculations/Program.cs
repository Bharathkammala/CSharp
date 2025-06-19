using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOps;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Classic.Multiply(3, 6));
            Console.WriteLine(Complex.Power(2, 5));
            Console.WriteLine(Complex.Root(2, 81));
        }
    }
}
