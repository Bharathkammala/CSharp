using System;


namespace Add_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking Inputs From the User

            Console.WriteLine("Enter your First Number");
            int iFirstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Second Number");
            int iSecsum= Convert.ToInt32(Console.ReadLine());

            //ADDING  Two Numbers
            int isum= iFirstnum + iSecsum;
            
            //Printing the Output
            Console.WriteLine("Sum Of Two Numbers : " + isum);
        }
    }
}
