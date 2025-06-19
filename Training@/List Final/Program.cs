using System;
using System.Collections.Generic;


namespace List_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lstInfo = new List<string>();

            Console.Write("Enter Your Name : ");
            string strName = Console.ReadLine();

            Console.WriteLine("Enter Your Address ");
            Console.Write("Line 1 : ");
            string strLine1 = Console.ReadLine();

            Console.Write("Line 2 : ");
            string strLine2 = Console.ReadLine();

            Console.Write("Line 3 : ");
            string strLine3 = Console.ReadLine();

            Console.Write("Enter your Gender : ");
            string strSex = Console.ReadLine();

            //Addings the user input values into the list using .Add method

            lstInfo.Add(strName);
            lstInfo.Add(strLine1);
            lstInfo.Add(strLine2);
            lstInfo.Add(strLine3);
            lstInfo.Add(strSex);

            //Calling the Method to print the info
            Displayinfo(lstInfo);
        }

            //Creating Method To display the details
        public static void Displayinfo(List<string> infolist)
        {
            Console.WriteLine("-----Personal Details-----");
            Console.WriteLine($"Name : {infolist[0]}");
            Console.Write($"Address : ");
            Console.WriteLine($"{infolist[1]}");                        
            Console.WriteLine($"          {infolist[2]}");              //Adding spaces at starting to get the Format output 
            Console.WriteLine($"          {infolist[3]}");
            Console.WriteLine($"Gender : {infolist[4]}");
        }
    }
}
