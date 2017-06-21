using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStruct
{
    /*
       Notes:
       
       Structs cannot inherit other structures or classes
       Cannot be used as a base for other structs or classes
       Can Implement 1 or more interfaces
       Cannot be abstract, virtual or protected
       Can be instantiated without using the new operator
       If new operator is not used, the object cannot be used until all fields are initialized    

       Class versus Structure
       Classes and Structures have the following basic differences:
       classes are reference types and structs are value types
       Structures do not support inheritance
       Structures cannot have default constructor
    */

    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Books Book1;
            Books Book2;

            //Book 1 Specification
            Book1.title = "C# 6.0 in a Nutshell";
            Book1.author = "Joseph Albahari & Ben Albahari";
            Book1.subject = "C# Programming";
            Book1.book_id = 001;

            //Book 2 Specification
            Book2.title = "Programming in C#";
            Book2.author = "Wouter de Kort";
            Book2.subject = "C# Programming";
            Book2.book_id = 002;

            //Print Book Details
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

            Console.ReadLine();
        }
    }
}
