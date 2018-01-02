using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowAllFoldersUnder(@"c:\files", 0);
        }

        private static void ShowAllFoldersUnder(string path, int indent)
        {
            foreach (string folder in Directory.GetDirectories(path))
            {
                files(folder, indent); // assignment
                Console.WriteLine("{0}{1}", new string(' ', indent), Path.GetFileName(folder) +" : created on ("+ File.GetCreationTime(folder)+")");
                ShowAllFoldersUnder(folder, indent + 2);
            }
        }

        // Assignment
        public static void files(string folder, int indent)
        {
            string[] dirs = Directory.GetFiles(folder);
            //Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
            foreach (string dir in dirs)
            {
                //Console.WriteLine(dir,indent+3);
                Console.WriteLine("{0}{1}", new string(' ', indent), dir + " : created on (" + File.GetCreationTime(dir)+")");
            }
        }
    }
}
