using System;
using System.IO;

namespace StringOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Mitchel\OneDrive - Mediacollege Amsterdam\Documenten\MA\Bewijzenmap\Periode 1.4\GD 4\2022P4csharp\Csharp2Opdrachten\StringOpdracht\StringOpdracht\stringsplit.txt");
            string[] split1 = text.Split(":");
            string[] split2 = split1[1].Split(",");

            foreach(string splitOne in split1)
            {
                Console.WriteLine(splitOne);
            }

            foreach (string splitTwo in split2)
            {
                Console.WriteLine(splitTwo);
            }
        }
    }
}
