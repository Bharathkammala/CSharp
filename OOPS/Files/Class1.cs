using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    public class FileOperation
    {
        public static string FullPath { get; set; }
        public string Name { get; set; }
        
        public string content { get;set; }

        public string GetFullName()
        {
            return Path.Combine(FullPath, Name);
        }

    } 
}
