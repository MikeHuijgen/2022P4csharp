using System;
using System.IO;

namespace StringOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\mikeh\MA\Bewijzenmap\Periode 1.4\C#\2022P4csharp\StringOpdracht\text.txt");

            string[] textArray = text.Split(':' ,',');

            foreach (string s in textArray)
            {
                Console.WriteLine(s);
            }

        }
    }
}
