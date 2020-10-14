using System;
using SharedClassLibrary;

namespace ReadWriteXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlService.WriteToFile(@"D:\Files\xml\books.xml");
            XmlService.ReadFromFile(@"D:\Files\xml\books.xml");
        }
    }
}
