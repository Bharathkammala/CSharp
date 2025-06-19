using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderOperations;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FolderInfo objFolder = new FolderInfo();
             string DirectoryPath = "D:\\C#";
             string  FilePath = "D:\\C#\\ConsoleCalculator\\history.txt";
            
            string Dirctorypath = "D:\\C#";
            objFolder.GetAllFolderNames(DirectoryPath);
        }
    }
}
