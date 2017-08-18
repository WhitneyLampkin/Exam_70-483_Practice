using System;
using System.IO;
using System.Text;

namespace FileIOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using Directory and DirecotryInfo

            //Get info about exisitng directories, which seem to be folders.
            DirectoryInfo currencyDirectory = new DirectoryInfo(".");

            DirectoryInfo myDirectory = new DirectoryInfo(@"C:\Users\Whitney");

            Console.WriteLine("Full Name:" + myDirectory.FullName);
            Console.WriteLine("Name:" + myDirectory.Name);
            Console.WriteLine("Parent:" + myDirectory.Parent);
            Console.WriteLine("Attributes:" + myDirectory.Attributes);
            Console.WriteLine("Creation Time:" + myDirectory.CreationTime);

            //Create a new directory (folder)
            Directory.CreateDirectory(@"C:\Users\Whitney\TestDirectory");

            DirectoryInfo dataDirectory = new DirectoryInfo(@"C:\Users\Whitney\TestDirectory");

            //Delete directory
            //Directory.Delete(@"C:\Users\Whitney\TestDirectory");

            #endregion

            #region Using File and FileInfo
             
            string[] customers =
            {
                "Customer 1",
                "Customer 2",
                "Customer 3"
            };

            //Specifying new file path
            string textFilePath = @"C:\Users\Whitney\TestDirectory\testfile1.txt";

            //Creating new text file in the created folder
            File.Create(textFilePath);

            //Writing the customer array to the text file created
            File.WriteAllLines(textFilePath, customers);

            //Reading from the text file recently created
            foreach (var cus in File.ReadAllLines(textFilePath))
                Console.WriteLine($"Customer: {cus}");

            //Gives access to information for the directory specified
            DirectoryInfo myTestDirectory = new DirectoryInfo(@"C:\Users\Whitney\TestDirectory");


            //Get all .txt files in the directory
            FileInfo[] txtFiles = myTestDirectory.GetFiles("*.txt", SearchOption.AllDirectories);

            //Writing data from the FileInfo above
            Console.WriteLine("Matches: {0}", txtFiles.Length); ;

            //Writing data from the FileInfo above
            foreach (var file in txtFiles)
                Console.WriteLine(file.Name + " " + file.Length);

            #endregion

            #region Using FileStreams (Bytes and uses Encoding)

            //FileStreams are used to read/write bytes or array of bytes

            //Specify a file name
            string textFilePath2 = @"C:\Users\Whitney\TestDirectory\testfile2.txt";                            //Notice we use the .txt for Filestreams

            //Open or Create a file if it already hasn't been created
            FileStream fs = File.Open(textFilePath2, FileMode.Create);

            //Creating a random string to use 
            string randomString = "This is a random string";

            //Getting the byte array of the string specified
            byte[] rsByteArray = Encoding.Default.GetBytes(randomString);

            //Write to file by defining the byte array, index to start with and length

            fs.Write(rsByteArray, 0, rsByteArray.Length);

            //Change FileStream position back to 0 (beginning) to read from it.
            fs.Position = 0;

            //Creating a byte array to hold the file data we read.
            byte[] fileByteArray = new byte[rsByteArray.Length];

            //Putting the byte inside of the array so it can be manipulated and read through
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                //Takes each byte from the FileStream and adds it to the byte array
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            //Convert from byte to string and output it
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            fs.Close();

            #endregion

            #region Using StreamWriter/StreamReader (Strings)

            //StreamWriters and Readers are used for reading/writing strings (instead of bytes)
            string textFilePath3 = @"C:\Users\Whitney\TestDirectory\TestFile3.txt";                             //Notice we use the .txt filetype with streamwriters.readers

            StreamWriter sw = File.CreateText(textFilePath3);

            sw.Write("This is a random ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is a different sentence.");

            sw.Close();

            StreamReader sr = File.OpenText(textFilePath3);

            //Peek returns the next available value but doesn't consume it.
            //This obviously starts at 0 because we haven't moved the position.
            Console.WriteLine("Peek: {0}", Convert.ToChar(sr.Peek()));

            //Reads 1 line at a time only.
            Console.WriteLine("1st String: {0}", sr.ReadLine());

            //Starts at the currency position and reads to the end.
            Console.WriteLine("Everything: {0}", sr.ReadToEnd());

            //Closes stream and releases underlying resources
            sr.Close();

            #endregion

            #region BinaryWriter/BinaryReader (Data Types)

            //Binary readers and writers are used to read and write datatypes

            string textFilePath4 = @"C:\Users\Whitney\TestDirectory\TestFile4.dat";                              //Notice we use the .dat filetype with binarywriters/readers

            FileInfo datFile = new FileInfo(textFilePath4);

            //Open the file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            //Create info to store inside 
            string randomText = "Random Text";
            int myAge = 30;
            double height = 5.5;

            bw.Write(randomText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());                                             //Throws a System.IO.IOException if the bw isn't closed.

            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            #endregion

            Console.ReadLine();
        }
    }
}
