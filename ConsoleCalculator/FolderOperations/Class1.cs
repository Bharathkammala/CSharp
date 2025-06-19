using System;
using System.Collections.Generic;
using System.IO;

namespace FolderOperations
{
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

