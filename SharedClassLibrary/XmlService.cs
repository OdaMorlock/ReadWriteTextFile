using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SharedClassLibrary
{
    public static class XmlService
    {
        public static void WriteToFile(string filepath)
        {
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = ("  "),
                CloseOutput = true
            };

            using XmlWriter xml = XmlWriter.Create(filepath, settings);

            xml.WriteStartElement("books");
            xml.WriteStartElement("book");
            xml.WriteAttributeString("author", "Kalleplanka");
            xml.WriteElementString("title", "Bokens Titel");
            xml.WriteEndElement();
            xml.WriteStartElement("book");
            xml.WriteAttributeString("author", "Kallefjanka");
            xml.WriteElementString("title", "Bokens Titels");
            xml.WriteEndElement();
            xml.WriteEndElement();

            xml.Flush();
        }

        public static void ReadFromFile(string filepath)
        {
            using XmlTextReader xml = new XmlTextReader(filepath);

            xml.Read();

            while (xml.Read())
            {
                //Console.WriteLine(xml.LocalName);
                //Console.WriteLine(xml.Name);
                //Console.WriteLine(xml.NodeType);
                //Console.WriteLine(xml.Value);
                //Console.WriteLine(xml.ReadAttributeValue());

                XmlNodeType ntype = xml.NodeType;

                if (ntype == XmlNodeType.Element)
                {
                    if (xml.Name == "book")
                    {
                        
                        Console.WriteLine("Author:" + xml.GetAttribute("author"));
                        
                    }
                    
                }

                if (ntype == XmlNodeType.Text)
                {
                    Console.WriteLine(xml.Value);
                }

                
            }
        }
    }
}
