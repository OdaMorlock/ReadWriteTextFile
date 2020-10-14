using SharedClassLibrary;
using System;

namespace ReadWriteJsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // JsonService.WriteToFile(@"D:\Files\json\persons.json", new Person("Marcus","Bakcstrom", 25, "God", "Unmatched"));

            // JsonService.ReadFromFile(@"D:\Files\json\persons.json");

            JsonService.WriteToFileCorrect(@"D:\Files\json\persons.json", new Person("Marcus", "Bakcstrom", 25, "God", "Unmatched"));
        }
    }
}
