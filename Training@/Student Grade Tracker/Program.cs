using System;
using System.Collections.Generic;


namespace Student_Grade_Tracker
{
    internal class Program
    {
        //Creating a dictionary to store  students name and his grades
        static Dictionary<string, string> dictStudDetails = new Dictionary<string, string>();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Student Grade Tracker" + "\n");
            //Collectinfo();



            //Creating a loop to select options for user until he quits the program
            bool loop = true;
            while (loop)
            {
                Selectoption();
                string strChoice = Console.ReadLine();

                //Using Switch case to Execute different blocks of code (for each option) 
                switch (strChoice)
                {
                    case "1":
                        Addinfo();
                        break;
                    case "2":
                        Getinfo();
                        break;
                    case "3":
                        Removeinfo();
                        break;
                    case "4":
                        Displayinfo();
                        break;
                    case "5":
                        loop = false;                                    //if user enters option 5 loop will become false and program terminates
                        Console.WriteLine("Exiting the Program" + "\n");
                        break;
                    default:
                        Console.Write("Invalid Choice Choose Correct Option : "); //if user enters invalid option (aside from option 1-5)
                        break;
                }
                Console.WriteLine("\n" + "\n");                         //To create Gap between options and methods
            }
        }

        //Creating a function to takeintial student details from user

        public static void Collectinfo()
        {
            Console.WriteLine("Enter Student Details ");
            dictStudDetails["Name "] = Getinput("Enter Student Name : ");
            dictStudDetails["Grade "] = Getinput("Enter grades : ");

        }

        //Creating Addinfo function to add student data
        public static void Addinfo()
        {
            Console.Write("\nEnter the Student Name : ");
            string strname = Console.ReadLine();
            Console.Write("Enter students grade : ");
            string strgrade = Console.ReadLine();
            dictStudDetails[strname] = strgrade;
        }

        //Creating Getinfo Function to print selected student data
        public static void Getinfo()
        {
            Console.Write("\nEnter Student Name : ");
            string strname = Console.ReadLine();
            Console.WriteLine(dictStudDetails[strname]);
        }

        //Creating Remove function to delete student details
        public static void Removeinfo()
        {
            Console.WriteLine("\nEnter student Name to Delete : ");
            string strname = Console.ReadLine();
            dictStudDetails.Remove(strname);
            Console.WriteLine("Removed Sucessfully" + "\n");
        }

        //Creating Displayinfo function to display whole student details
        public static void Displayinfo()
        {
            Console.WriteLine("Students Details are :- ");
            foreach (var entry in dictStudDetails)
            {

                Console.WriteLine($"Student Name : {entry.Key}\n Grades : 1{entry.Value}");
            }

        }

        //Creating a function to select an option for user
        public static void Selectoption()
        {
            Console.WriteLine("1.Add Student and his Grades" + "\n");
            Console.WriteLine("2.Select Student Name" + "\n");
            Console.WriteLine("3.Select a Student to remove" + "\n");
            Console.WriteLine("4.Show Full Info" + "\n");
            Console.WriteLine("5.Exit the program" + "\n");
            Console.WriteLine("Select a Choice from 1-5" + "\n");
        }


        public static string Getinput(string input)
        {
            Console.Write(input);
            return Console.ReadLine();

        }
    }
}
