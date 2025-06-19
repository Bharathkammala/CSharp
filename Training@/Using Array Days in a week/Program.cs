using System;


namespace Using_Array_Days_in_a_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");                     // Taking input from user
            int inumber = Convert.ToInt32(Console.ReadLine());      //  Converting user input into integer
            string[] arrdays = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
            //Condition to check input is between 1 to 7

            if (inumber > 0 && inumber < 7)
            {
                Console.WriteLine($"Corresponding day the number is : {arrdays[inumber - 1]}");
            }
            else
            {
                Console.WriteLine("Enter the number between (1-7)");
            }
        }
    }
}
