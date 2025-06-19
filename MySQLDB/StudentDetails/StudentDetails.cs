using MySqlDBOperations;
using System;
using System.Data;


namespace StudentDetails
{
    enum MainOption
    {
        Create = 1,
        Update = 2,
        Delete = 3,
        Display = 4,
        Exit = 0
    }

    /// <summary>
    /// I
    /// </summary>
    internal class StudentDetails
    {
        static Helper objStudentinfo = new Helper("Server=localhost;Database=college;User ID=admin;Password=pass@word");
        static void Main(string[] args)
        {




            Console.WriteLine("Welcome To Student Personal Details \n");

            //switch case is using to perform related operations
            
            int iSelectedOption;
            do
            {
                iSelectedOption = MainMenu();

                switch (iSelectedOption)
                {
                    case (int)MainOption.Create:
                        CreateDetails();
                        break;
                    case (int)MainOption.Update:
                        UpdateDetails();
                        break;
                    case (int)MainOption.Delete:
                        DeleteDetails();
                        break;
                    case (int)MainOption.Display:
                        DisplayDeatils();
                        break;
                    case (int)MainOption.Exit:
                        break;
                }
            } while (iSelectedOption != 0);
        }

        /// <summary>
        /// it asks user to enter details to be updated and performs ExecuteCRUDcommand method to push to mysqldb database
        /// </summary>
        public static void CreateDetails()
        {


            Console.WriteLine("Enter Student First Name : ");
            string strFirstName = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name : ");
            string strLastName = Console.ReadLine();
            Console.WriteLine("Enter Age : ");
            int iAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender of the Student : ");
            string strGender = Console.ReadLine();
            Console.WriteLine("Enter Student Mother Name : ");
            string strMotherName = Console.ReadLine();
            Console.WriteLine("Enter Student Father Name : ");
            string strFatherName = Console.ReadLine();
            Console.WriteLine("Enter Student Address : ");
            string strAddress = Console.ReadLine();
            Console.WriteLine("Enter Student Postal Code : ");
            int iPostalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Country : ");
            string strCountry = (Console.ReadLine());
            Console.WriteLine("Enter Student Phone no : ");
            double dPhoneNo = Convert.ToDouble(Console.ReadLine());


            //date and time is converted to string using builtin function DateTime.Now
            string strCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            string strUpdate = $"INSERT INTO studentinfo (`firstname`, `lastname`, `age`, `gender`, `mothername`, `fathername`, `address`, `postalcode`, `country`, `phoneno`, `created_datetime`) " +
                               $"VALUES ('{strFirstName}', '{strLastName}', {iAge}, '{strGender}', '{strMotherName}', '{strFatherName}', '{strAddress}', {iPostalCode}, '{strCountry}', {dPhoneNo}, '{strCurrentDateTime}');";
            int iResultOne = objStudentinfo.ExecuteCRUDCommand(strUpdate);
            if (iResultOne > 0)
            {
                Console.WriteLine($"Successfully Updated\nRows Affected : {iResultOne}");
            }

            

        }

        /// <summary>
        /// it asks user to select a student id to delete
        /// </summary>
        public static void DeleteDetails()
        {
            

            Console.WriteLine("Enter Student ID to Delete: ");
            string strName = Console.ReadLine();

            string strDelete = $"DELETE FROM `studentinfo` WHERE `idstudentinfo` = {strName};";
            int iResultTwo = objStudentinfo.ExecuteCRUDCommand(strDelete);
            if (iResultTwo > 0)
            {
                Console.WriteLine($"Successfully Deleted\nRows Affected : {iResultTwo}");
            }
            else
            {
                Console.WriteLine("Error Deleting Student Record");
            }

        }

        /// <summary>
        /// it update details taken from the user into exisiting student id 
        /// </summary>
        public static void UpdateDetails()
        {
            Console.WriteLine("Enter Student ID to Update: ");
            int iStudentId = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter Student First Name : ");
            string strFirstName = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name : ");
            string strLastName = Console.ReadLine();
            Console.WriteLine("Enter Age : ");
            int iAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender of the Student : ");
            string strGender = Console.ReadLine();
            Console.WriteLine("Enter Student Mother Name : ");
            string strMotherName = Console.ReadLine();
            Console.WriteLine("Enter Student Father Name : ");
            string strFatherName = Console.ReadLine();
            Console.WriteLine("Enter Student Address : ");
            string strAddress = Console.ReadLine();
            Console.WriteLine("Enter Student Postal Code : ");
            int iPostalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Country : ");
            string strCountry = Console.ReadLine();
            Console.WriteLine("Enter Student Phone No : ");
            double dPhoneNo = Convert.ToDouble(Console.ReadLine());

            string strCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            string strUpdate = $"UPDATE studentinfo SET firstname = '{strFirstName}', lastname = '{strLastName}', age = {iAge}, gender = '{strGender}', mothername = '{strMotherName}', fathername = '{strFatherName}', address = '{strAddress}', postalcode = {iPostalCode}, country = '{strCountry}', phoneno = {dPhoneNo}, modified_datetime = '{strCurrentDateTime}' WHERE idstudentinfo = {iStudentId};";

            int iResultThree = objStudentinfo.ExecuteCRUDCommand(strUpdate);
            if (iResultThree > 0)
            {
                Console.WriteLine($"Successfully Updated Student Record\nRows Affected: {iResultThree}");
            }
            else
            {
                Console.WriteLine("Error Updating Student Record");
            }
        }




        /// <summary>
        /// it returns data from database and stored in datatable datatype
        /// </summary>
        public static void DisplayDeatils()
        {
            DataTable dtStudentData = objStudentinfo.ExecuteSelectQuery("SELECT firstname,lastname,age,gender FROM studentinfo ");
            Console.WriteLine("\nStudent Records are \n");


            foreach (DataColumn column in dtStudentData.Columns)
            {
                Console.Write(string.Format("{0,-10} |", column.ColumnName));           // 0 is the index and -10 indicates left alignment through 10 spaces  
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', dtStudentData.Columns.Count * 13));       //'-' char is multiplied by no of columns in data base * 13   

            foreach (DataRow row in dtStudentData.Rows)                                // looping through data base to print rows and columns (like matrix)
            {
                foreach (DataColumn column in dtStudentData.Columns)
                {
                    object Data = row[column.ColumnName];
                    Console.Write(string.Format("{0,-10} |", Data));
                }
                Console.WriteLine(); // Move to next line after each row
            }
            Console.WriteLine(new string('-',dtStudentData.Columns.Count*13));                    //'-' char is multiplied by no of columns in data base * 13 
            Console.WriteLine(string.Format("Total records: " + dtStudentData.Rows.Count));

        }

        /// <summary>
        /// it display user menu to select an option 
        /// </summary>
        /// <returns>selected option will retirn as int </returns>
        public static int MainMenu()
        {
            Console.WriteLine("\n1 : Create");
            Console.WriteLine("2 : Update");
            Console.WriteLine("3 : Delete");          
            Console.WriteLine("4 : Display");
            Console.WriteLine("0 : Exit");
            int iSelectedOption = Convert.ToInt32(Console.ReadLine());
            return iSelectedOption;
        }
        
    }
   
}




