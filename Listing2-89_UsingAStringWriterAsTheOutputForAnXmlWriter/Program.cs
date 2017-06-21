using System;
using System.IO;
using System.Xml;

namespace Listing2_89_UsingAStringWriterAsTheOutputForAnXmlWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringWriter and StringReader are necessary when working with APIs that need a TextWriter or TextReader.
            // Those APIs can't work with StringBuilders directly. 
            // These classes adapt the interface of teh STringBuilder so they can be used instead.

            var stringWriter = new StringWriter();

            // The XmlWriter creates XML text.
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }

            string xml = stringWriter.ToString();

            Console.WriteLine(xml);

        }
    }
}
