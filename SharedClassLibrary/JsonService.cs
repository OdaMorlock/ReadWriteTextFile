using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace SharedClassLibrary
{
    public static class JsonService
    {

      public static void WriteToFile(string filepath,Person person)
        {

            var json = JsonConvert.SerializeObject(person);

            using StreamWriter writer = new StreamWriter(filepath);

            writer.WriteLine(json);
            
        }  

        public static void ReadFromFile(string filepath)
        {
            using StreamReader reader = new StreamReader(filepath);

            var json = reader.ReadToEnd();

            Console.WriteLine(json);

        }

    }
}
