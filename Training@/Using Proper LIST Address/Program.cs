using System;
using System.Collections.Generic;
using System.Linq;


namespace Using_Proper_LIST_Address
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name,address in line1,line2,line3 and your Gender seperated by commas respectively");
            string strinfo = Console.ReadLine();
            List<string> lstDetails = strinfo.Split(',').ToList();
            DisplayInfo(lstDetails);
        }
            
            public static void DisplayInfo(List<string> details)
            { 
                for (int i = 0; i < details.Count; i++)
                {
                Console.WriteLine(details[i]);
                }
            }
    }
}