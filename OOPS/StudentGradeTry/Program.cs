using System;
using System.Collections.Generic;



namespace StudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UpdateStudentDetails oStudent = new UpdateStudentDetails();
            Dictionary<string, Decimal> dictStudentinfo = oStudent.UpdateData();
            option objOption = new option();
            int ich=objOption.Choice();
            bool loop = true;
            while (loop)
            {
                switch (ich)
                {
                    case 1:
                        dictStudentinfo=oStudent.UpdateData();
                        break;
                  
                    case 2:
                        Display objDisplay = new Display();
                        objDisplay.DisplayData(dictStudentinfo);
                        break;
                    case 3:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Enter a Valid Option");
                        break;
                }
            }

            
            


        }

        class UpdateStudentDetails
        {
            public Dictionary<string, Decimal> UpdateData()
            {
                Dictionary<string, Decimal> dictStudInfo = new Dictionary<string, Decimal>();
                Console.WriteLine("Welcome to Student Grade Academics");
                Console.Write("\nHow many Student Details do you want to Enter : ");
                int icount = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < icount; i++)
                {
                    Console.Write("\nEnter student Name : ");
                    string strName = Console.ReadLine();
                    Console.Write("\nEnter student Grade(1-10) : ");
                    Decimal dGrade = Decimal.Parse(Console.ReadLine());
                    dictStudInfo.Add(strName, dGrade);
                }
                return dictStudInfo;
            }


        }
        class Display
        {
            public void DisplayData(Dictionary<string, Decimal> dictStudentData)
            {
                Console.WriteLine("\nStudent Details are");
                foreach (var entry in dictStudentData)
                {
                    Console.WriteLine($"\nStudent Name : {entry.Key} \nGrade : {entry.Value}");

                }
                Console.ReadKey();
            }
        }

        class option
        {
            public  int Choice()
            {
                Console.WriteLine("Select an option from Below ");
                Console.WriteLine("1. Update Details");
                Console.WriteLine("2 Show Data");
                Console.WriteLine("3 Exit Program");
                return Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
