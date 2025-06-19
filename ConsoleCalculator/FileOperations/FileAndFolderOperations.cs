using System;
using System.Collections.Generic;
using System.IO;

namespace Operations
{
    public class FileOperations
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public string Content { get; set; }

        public string GetFullFileName()
        {
            return Path.Combine(FullPath, Name);
        }
        public void CreateFile()
        {
            string strFullFilePath = GetFullFileName();
            bool bFileExistsInfo = File.Exists(strFullFilePath);
            if (bFileExistsInfo == false)
            {


                File.Create(strFullFilePath).Dispose(); // Create the file and close it immediately


                //using (FileStream fs = File.Create(strFullFilePath))
                //    {

                //    }


                //File.WriteAllText(CompletePath, ""); // Create the file with empty string if file not present 
                //                                     //Draw back it replace existance file if already present with empty string 



                Console.WriteLine($"File created at {strFullFilePath}");
            }
            else
            {

                //throw new IOException($"File already exists at {strFullFilePath}");


                Console.WriteLine($"File already exists at {strFullFilePath}");


            }

        }


        public bool IsFileEmpty()             // Returns true or false whether file exists or not 
        {
            string strFullFilePath = GetFullFileName();

            return new FileInfo(strFullFilePath).Length == 0;
        }

        public bool IsFileExists()
        {
            string strFullFilePath = GetFullFileName();
            return System.IO.File.Exists(strFullFilePath);
        }



        public void ReadFile()
        {
            string strFullFilePath = GetFullFileName();


            if (File.Exists(strFullFilePath))
            {
                Content = File.ReadAllText(strFullFilePath);

                Console.WriteLine($"Reading file at {strFullFilePath}:\n{Content}");
            }
            else
            {
                throw new FileNotFoundException($"File not found at {strFullFilePath}");


                //Console.WriteLine($"File not found at {strFullFilePath}");

            }
        }
        public void WriteFile(string content)
        {
            string strFullFilePath = GetFullFileName();



            //if (Directory.Exists(strFullFilePath))  //checks Only Folder existence not File Existence



            if (Directory.Exists(Path.GetDirectoryName(strFullFilePath)))
            {
                Content = content;                                               // Creating Instance Variable to store passed Content
                File.WriteAllText(strFullFilePath, Content);                    //Write all content into a file using full file path details
                Console.WriteLine($"Contents Written To {strFullFilePath} ");

            }
            else
            {

                throw new DirectoryNotFoundException($"Directory not found at {strFullFilePath}");


                //Console.WriteLine($"Directory not found at {strFullFilePath}");

            }


        }
        public void AppendToFile(string content)
        {
            string strFullFilePath = GetFullFileName();

            if (File.Exists(strFullFilePath))
            {
                Content = content;                                   // Creating Instance Variable to store passed Content
                File.AppendAllText(strFullFilePath, Content);       //Updating the content into Existing File

            }
            else
            {
                throw new FileNotFoundException($"File not found at {strFullFilePath}");

                //Console.WriteLine($"File not found at {strFullFilePath}");

            }

        }

        public void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {

                File.Delete(filePath);
                FullPath = filePath;
                Console.WriteLine($"File deleted at {filePath}");
            }
            else
            {

                throw new FileNotFoundException($"File not found at {filePath}");


                //Console.WriteLine($"File not found at {filePath}");

            }


        }

       
    }



    //-------------------FolderOperations---------------------

    /// <summary>
    /// FolderInfo is a method to retrive inputs and assign to instance variable
    /// </summary>

    public class FolderInfo
    {
        public string DirectoryPath { get; set; }
        public string FilePath { get; set; }


        public List<string> GetAllFolderNames(string DirectoryPath)
        {
            List<string> FolderNamesList = new List<string>();

            bool bFolderExsists = Directory.Exists(DirectoryPath);

            if (bFolderExsists)
            {
                string[] Folder = Directory.GetDirectories(DirectoryPath);

                foreach (string foldername in Folder)
                {
                    string FolderName = Path.GetFileName(foldername);
                    FolderNamesList.Add(FolderName);
                }
                Console.WriteLine($"Folders Found in : {DirectoryPath} are");
                foreach (string FolderName in FolderNamesList)
                {
                    Console.WriteLine($"{FolderName}");
                }
            }
            else
            {
                Console.WriteLine("Directory Not Found");
            }
            return FolderNamesList;

        }

        public void ReadFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                string Content = File.ReadAllText(FilePath);
                Console.WriteLine($"File read successfully at {FilePath} \nFileContent :\n{Content}");
            }
            else
            {
                Console.WriteLine($"File not found at {FilePath} ");
            }
        }
    }
}


    // -------------CsvFile--------------

    //public class CsvFile : FileOperations
    //{
    //    public string Name { get; set; }

    //    public int Age { get; set; }

    //    public string Email { get; set; }

    //    public string Grade { get; set; }


    //    public void 






 
