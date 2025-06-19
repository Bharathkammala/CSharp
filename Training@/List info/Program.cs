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
            lstInfo.Add(strName);
            lstInfo.Add(strLine1);
            lstInfo.Add(strLine2);
            lstInfo.Add(strLine3);
            lstInfo.Add(strSex);
            Displayinfo(lstInfo);
        }
        public static void Displayinfo(List<string> infolist)
        {
            List<string> strLabels = new List<string>(){ "Name : ", "Address Line 1 : ","Address Line 2 :", "Address Line 3 :", "Gender : " };
            for (int i = 0; i < infolist.Count; i++)
            {
                Console.WriteLine($"{strLabels[i]} {infolist[i]}");
            }
        }
    }
}
