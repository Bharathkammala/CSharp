using System;


namespace Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter different numbers giving space ");
            string numbers = Console.ReadLine();
            string[] strnum = numbers.Split(' ');
            int[] i= new int[strnum.Length];
            for (int j = 0; j < strnum.Length; j++)
            {
                int[j]= Convert.ToInt32(strnum[j]);
            }

        }
    }
}
