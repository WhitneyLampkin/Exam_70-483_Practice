using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Listing2_90_UsingAStringReaderAsTheInputForAnXmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var stringReader = new StringReader(xml);

            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(),
                    new CultureInfo("en-US")); //Make sure that you read the decimal part correctly

                Console.WriteLine(price);
            }
        }
    }
}
