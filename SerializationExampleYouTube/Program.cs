using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SerializationExampleYouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the animal class
            Animal bowser = new Animal("Bowser", 45, 25);

            //Create and/or open the specified file to store the open data
            //Provides a generic view of a sequence of bytes. (Stream is an abstract class.)
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);

            //Serializes or deserializes an object, or entire graph of connected objects, in binary format.
            BinaryFormatter bf = new BinaryFormatter();

            //Sending object data to the file.
            bf.Serialize(stream, bowser);
            stream.Close(); //Not closing the stream throws an error here.

            //Delete the stored data to prove it was saved
            bowser = null;

            //Read the object data from the file
            stream = File.Open("AnimalData.dat", FileMode.Open);
            
            bf = new BinaryFormatter();

            //Get the data
            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine(bowser.ToString());

            //Changing bowser so we can determine which object is being used
            bowser.Weight = 50;

            XmlSerializer serializer = new XmlSerializer(typeof(Animal));

            //We don't have to close the stream here like we did before because we are using the 'using' statement.
            using (TextWriter tw = new StreamWriter(@"C:\Users\Whitney\C#Data\bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            }

            bowser = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\Whitney\C#Data\bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close(); //We need to close the reader to access the information again.

            Console.WriteLine(bowser.ToString());

            //Now, with a collection of 'Animals'
            //Creating the collection of Animals
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Animal1", 60, 30),
                new Animal("Animal2", 55, 24),
                new Animal("Animal3", 40, 20)
            };

            //Writing the objects to the XML file
            using (Stream fs = new FileStream(@"C:\Users\Whitney\C#Data\bowser.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }

            //Setting the collection to null to verify that we are reading from the file
            theAnimals = null;

            //Deserializing from the file
            XmlSerializer deserializer2 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\Whitney\C#Data\bowser.xml"))
            {
                theAnimals = (List<Animal>)deserializer2.Deserialize(fs2);
            }

            foreach (var a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }
    }

    [Serializable()]
    public class Animal : ISerializable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal() { }

        public Animal(string name = "No Name", double weight = 0, double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} lbs and is {2} inches tall", Name, Weight, Height);
        }


        // SerializationInfo holds key/value pairs for the object data
        //Serialization Method
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
        }

        //Deserialization Method
        public Animal(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
        }
    }
}
