using System;
using System.Collections.Generic;


namespace Address_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");
            string strName = Console.ReadLine();
            Console.WriteLine("Enter the address ");
            Console.Write("Line 1 : ");
            string strLine1= Console.ReadLine();
            Console.Write("Line 2 : ");
            string strLine2= Console.ReadLine();
            Console.Write("Line 3 : ");
            string strLine3= Console.ReadLine();
            Console.Write("Enter your age : ");
            int intage= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Gender : ");
            string strsex=(Console.ReadLine());
            Console.WriteLine($"Name :{strName} \nAddress :{strLine1}\n{strLine2}\n{strLine3}\nSex : {strsex.ToUpper()}");
        }
    }
}
