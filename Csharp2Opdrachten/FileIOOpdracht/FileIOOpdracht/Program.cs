using System;
using System.IO;

namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Mitchel\OneDrive - Mediacollege Amsterdam\Documenten\MA\Bewijzenmap\Periode 1.4\GD 4\2022P4csharp\Csharp2Opdrachten\FileIOOpdracht\FileIOOpdracht\TextFile.txt");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
