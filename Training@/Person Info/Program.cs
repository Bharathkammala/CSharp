using System;
using Operations;
using System.IO;


namespace Person_Info
{
    internal class Program  
    {
        static FileOperations FileOps = new FileOperations()
        {
            FullPath = "D:\\C#\\ConsoleCalculator",
            Name = "StudentBio.csv"
        };

        public static void Main(string[] args)
        {
            string strFullFilePath = FileOps.GetFullFileName();
            if (File.Exists(strFullFilePath))
            {
                //Does nothing
            }
            else
            {
                FileOps.CreateFile();
            }

            string csvfile = "D:\\C#\\ConsoleCalculator\\StudentBio.csv\\";

            if (new FileInfo(csvfile).Length==0)
            {
                string Headers = "Sl.No,Name,Age,Gender,EmailAddress,Weight\n";
                FileOps.AppendToFile(Headers);
            }

            Console.Write("Enter your name : ");
            string strName = Console.ReadLine();
            Console.Write("Enter your Age : ");
            int iAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Gender :");
            char chGender = char.ToUpper(Console.ReadLine()[0]); // Reads the first character of the input and convert it into Upper case  
            Console.Write("Enter your Email Address : ");
            string strEmail = Console.ReadLine();
            Console.Write("Enter your Weight : ");
            decimal dweight = Convert.ToDecimal(Console.ReadLine());  //
            Console.Write("\n--Personal info--\nName : "+ strName + "\nAge : " + iAge + "\nGender : " + chGender + "\nEmail :" + strEmail + "\nWeight : " + dweight);
            
            
            string CsvRow = ($"1,{strName},{iAge},{chGender},{strEmail},{dweight}\n");
            FileOps.AppendToFile(CsvRow);

        }
    }
}
