using System;
using System.Collections.Generic;
using System.IO;

namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteToFile("persons.txt", "Marcus, Är ,Bäst,God,Like");
        }

        private static void WriteToFile(string filename,string text)
        {
            var lines = new List<string>();
            lines.Add(text);

            File.AppendAllLines(@$"D:\Files\{filename}", lines);

            //File.WriteAllLines(@$"D:\Files\{filename}", lines);

        }

    }
}
