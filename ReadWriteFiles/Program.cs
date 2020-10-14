using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteToFile("persons.txt", "Marcus, Är ,Bäst,GodLike");
            ReadFromFile("persons.txt");
        }

        private static void WriteToFile(string filename,string text)
        {
            var lines = new List<string>();
            lines.Add(text);

            //File.WriteAllLines(@$"D:\Files\{filename}", lines);
            File.AppendAllLines(@$"D:\Files\{filename}", lines);


        }

        private static void ReadFromFile(string filename)
        {
            Console.WriteLine("Using List");
            var lines = File.ReadAllLines(@$"D:\Files\{filename}").ToList();
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Using Array");
            var lines2 = File.ReadAllLines(@$"D:\Files\{filename}");
            foreach (var line in lines2)
            {
                Console.WriteLine(line);
            }

        }

    }
}
