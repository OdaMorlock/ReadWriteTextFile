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

            WriteToFile("persons.txt", "Marcus,Bäckström,25,Är Bäst,GodLike");
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
            var persons = new List<Person>();
            

            foreach(var line in lines)
            {
                var data = line.Split(',');
                

             persons.Add(new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3], data[4]));
                //persons.Add(new Person { FirstName = data[0], LastName = data[1], Age = Convert.ToInt32(data[2]), Condition = data[3], Status = data[4] });

                foreach(var person in persons)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} and is {person.Condition} and is  {person.Status}");
                }

            }

            

        }

    }
}
