using System;
using System.IO;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\mikeh\MA\Bewijzenmap\Periode 1.4\C#");

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }

            foreach (FileInfo files in directory.GetFiles())
            {
                Console.WriteLine(files.Name);
            }
        }
    }
}
