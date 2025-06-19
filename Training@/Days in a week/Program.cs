using System;
using System.Collections.Generic;

namespace Days_in_a_week
{
    internal class Program
    {
        /// <summary>
        /// dictDays stores the days in a week in {Key:Value} pair Format
        /// <para>String represents the day and key represents its respective number in a week</para>
        /// </summary>
        static Dictionary<int, string> dictDays = new Dictionary<int, string>
            {
                { 1, "Monday" },
                { 2, "Tuesday" },
                { 3, "Wednesday" },
                { 4, "Thursday" },
                {5,"Friday" },
                {6,"Saturday" },
                {7,"Sunday" }};
        static void Main(string[] args)
        {
            ////to display all days in a week
            //DisplayWeek();
            Console.Write("Enter a number : ");                       //Taking a number from user to print its corresponding day
            int inumber =Convert.ToInt32(Console.ReadLine());        //Converting the input string into Integer
            if (inumber > 0 && inumber < 8)                         // Condition to execute only when number is within the range
            {
                Nameoftheday(inumber);                             //Calling the Function 
            }
            else { Console.WriteLine("Enter number (1-7) "); }
                Console.ReadKey();                               //Keeping console open until user enter a key
           
        }
        public static void DisplayWeek()                      //Creating a Function to display all days in a week
        {

            foreach (var value in dictDays.Values)
            {
               Console.WriteLine(value);
            }
        }
        public static void Nameoftheday(int inumber)                    // creating a function to display corresponding day
        {
          
            Console.WriteLine($"Corresponding Day to that number : {dictDays[inumber]} ");
        }
    }
}
