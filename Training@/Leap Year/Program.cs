using System;


namespace Leap_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking a number as Input from user
            Console.Write("Enter a Number : ");
            int inum = Convert.ToInt32(Console.ReadLine());        //Convert it into integer
            int ibase = 2;
            int ipower = 1;

            ////Using For Loop 
            //for (int i = 0; i < inum; i++)
            //{
            //    ipower = ipower * ibase;
            //}

            //Using While Loop
            int i = 1;
            while (i <= inum)
            {
                ipower = ibase * ipower;
                i++;
            }
            Console.WriteLine(ipower);              //  Output 

        }
    }
}
