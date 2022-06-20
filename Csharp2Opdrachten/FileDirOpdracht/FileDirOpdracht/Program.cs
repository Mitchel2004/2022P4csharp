using System;
using System.IO;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Mitchel\OneDrive - Mediacollege Amsterdam\Documenten\MA\Bewijzenmap\Periode 1.4\GD 4\2022P4csharp");

            foreach(FileInfo file in directory.GetFiles())
            {
                Console.WriteLine(file.FullName);
            }
        }
    }
}
