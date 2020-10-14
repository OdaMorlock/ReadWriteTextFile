﻿using SharedClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteCsvFile
{
    class Program
    {
        private static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            
            string content = "Marcus; Backstrom; 25; God; UnMatched";

            CsvService.WriteToFile(@"D:\Files\csv\persons.csv",content);

           var persons = CsvService.ReadFromFile(@"D:\Files\csv\persons.csv");

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} and is {person.Condition} and is  {person.Status}");
            }
        }

       
       
        
    }
}
