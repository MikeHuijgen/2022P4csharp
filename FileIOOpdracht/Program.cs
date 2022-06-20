using System;
using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[] { "Ik ben Mike", "Ik ben 20 jaar oud en ik word later een game developer" };
            File.WriteAllLines(@"C:\Users\mikeh\MA\Bewijzenmap\Periode 1.4\C#\2022P4csharp\FileIOOpdracht\demo.txt", text);

            string[] lines = File.ReadAllLines(@"C:\Users\mikeh\MA\Bewijzenmap\Periode 1.4\C#\2022P4csharp\FileIOOpdracht\demo.txt");
            
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
