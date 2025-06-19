using System;
using System.Collections.Generic;
using System.Security.Policy;


namespace StudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UpdateStudentDetails oStudent = new UpdateStudentDetails();
            Dictionary<string, Decimal> dictStudentinfo = oStudent.UpdateData();
            Display objDisplay = new Display();
            objDisplay.DisplayData(dictStudentinfo);


        }

        class UpdateStudentDetails
        {
            public string[] Decimal[] UpdateData()
            {
                Console.WriteLine("Welcome to Student Grade Academics");
                Console.Write("\nHow many Student Details do you want to Enter : ");
                int icount = Convert.ToInt32(Console.ReadLine());
                string[] strName = new string[] { };
                for (int i = 0; i < icount; i++)
                {
                    Console.Write("\nEnter student Name : ");
                    string[] strName = { Console.ReadLine() };
                    Console.Write("\nEnter student Grade(1-10) : ");
                    Decimal[] dGrade = { Convert.ToDecimal(Console.ReadLine())};
              
                }
                return strName;
            }


        }
        class Display
        {
            public void DisplayData(Dictionary<string, Decimal> dictStudentData)
            {
                Console.WriteLine("\nStudent Details are");
                foreach (int i= 0;i<StrName.Length;i++)
                {
                    Console.WriteLine($"\nStudent Name : {strName[i]} \nGrade : {dGrade[int]}");

                }
                Console.ReadKey();
            }
        }

        //class option
        //{
        //    public static int Option()
        //    {
        //        Console.WriteLine("Select an option from Below ");
        //        Console.WriteLine("1. Update Details");
        //        Console.WriteLine("2 Show Data");
        //        Console.WriteLine("3 Exit Program");
        //        return Convert.ToInt32(Console.ReadLine());
        //    }
        //}
    }
}
