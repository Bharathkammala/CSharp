using System;
using System.Collections.Generic;

namespace StudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Creating an object from class UpdateStudentDetails
                UpdateStudentDetails objStudent = new UpdateStudentDetails();

                //Assigining the updated data into new dictionary to give access for Display Class 
                Dictionary<string, Decimal> dictStudentinfo = objStudent.UpdateData();

                //Creating an object to display data from class Display 
                Display objDisplay = new Display();

                //Calling the DisplayData method from class Display
                objDisplay.DisplayData(dictStudentinfo);

            
        }
        /// <summary>
        /// UpdateData is a method declared in UpdateStudentDetails Class to take Student info from user 
        /// </summary>
        class UpdateStudentDetails
        {
            //Return Type Dictionary
            public Dictionary<string, Decimal> UpdateData()
            {
                //Creating a new variable of Dictionary Type 
                Dictionary<string, Decimal> dictStudInfo = new Dictionary<string, Decimal>();

                Console.WriteLine("Welcome to Student Grade Academics");
                Console.Write("\nHow many Student Details do you want to Enter : ");  //To enter More than 1 student

                //Converting input from user into integer
                int icount = Convert.ToInt32(Console.ReadLine());

                //Creating a loop to get Multiple Students Data
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
            /// <summary>
            /// DisplayData is method in class Display to print stored Student Data
            /// </summary>
            /// <param name="dictStudentData"></param>Updated student Details are giving as a parameter 
            public void DisplayData(Dictionary<string, Decimal> dictStudentData)
            {
                Console.WriteLine("\nStudent Details are");

                //creating a loop to print key,value pairs in dictionary
                foreach (var entry in dictStudentData)
                {
                    Console.WriteLine($"\nStudent Name : {entry.Key} \nGrade : {entry.Value}");

                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Option is a method used in class option to Get integer as return value from user for selecting an option
        /// </summary>
        //class option
        //{
        //    public static int Option()
        //    {
        //        Console.WriteLine("Select an option from Below ");
        //        Console.WriteLine("1. Update Details");
        //        Console.WriteLine("2. Show Data");
        //        Console.WriteLine("3. Exit Program");
        //        return Convert.ToInt32(Console.ReadLine());
        //    }
        //}
    }
}
