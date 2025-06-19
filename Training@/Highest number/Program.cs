using System;


namespace Highest_number
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
            if (i > j && i > k)                                   /*Comparing 1st number with 2nd and 3rd and
                                                                  printing the 1st number if it satisfies the condition*/
            {
                Console.WriteLine(i + " is Highest Number");

            }
            else if (j > k && j > i)                                 /*Comparing 2nd number with 1st and 3rd and
                                                                  printing the 2nd number if it satisfies the condition*/
            {
                Console.WriteLine(j + " is Highest Number");

            }                                                     /*if it doesn't satisfy both then 
                                                                  else block will print i.e number 3rd*/ 
            else
            {
                Console.WriteLine(k + " is Highest number");
            }
        }
    }
}
