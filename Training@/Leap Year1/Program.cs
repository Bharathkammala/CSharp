using System;


namespace Leap_Year1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking input from User in YYYY Format
            Console.WriteLine("Enter a year in YYYY Format");
            int iYear = Convert.ToInt32(Console.ReadLine());
            //Conditional Statement for checking Leap Year
            if ((iYear % 4 == 0 && iYear % 100 != 0) || (iYear % 400 == 0))
            {
                Console.WriteLine("Its a Leap Year");
            }
            else
            {
                Console.WriteLine("it is not a leap year");
            }
        }
    }
}
