using System;
using System.Xml;
using System.Xml.Schema;

namespace Listing3_16_ValidatingAnXMLFileWithASchema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need to create the xsd file from the previous listing before running this code.
        }

        public void VaildateXMl()
        {
            string xsdPath = "person.xsd";
            string xmlPath = "person.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);

            ValidationEventHandler eventHandler = new System.Xml.Schema.ValidationEventHandler(ValidationEventHandler);
            document.Validate(eventHandler);
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning: {0}", e.Message);
                    break;
                default:
                    break;
            }
        }
    }
}
