using System;

namespace Concatination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your First Name ");  //Taking first name as  input from the user// 
            string strfirst = Console.ReadLine();
            Console.WriteLine(" Enter your Lat Name"); //Taking Last name as input from the user//
            string strlast = Console.ReadLine();
            Console.WriteLine(strfirst + ' ' + strlast);
        }
    }
}
