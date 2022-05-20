using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //string coursName = "Learn C# for Beginners Crash Course";
        //string message = "Welcom to ";

        //// Concatenate courseName and message to create a new string
        //string fullMessage = message + coursName;
        //Console.WriteLine(fullMessage);

        //// Use string interpolation 
        //string fullMessage2 = $"{message}{coursName}";
        //Console.WriteLine(fullMessage2);

        //// Use Composite Formatting with mehtods that support it
        //Console.WriteLine("Hello, and {0} the {1}", message, coursName );

        //for (int i = 0; i < coursName.Length; i++)
        //{
        //    char character = coursName[i];
        //    Console.WriteLine(character);
        //}
        //===============Video 124=================

        //static void Main(string[] args)
        //{
        //    //0         1         2         3  
        //    //0123456789012345678901234567890123456789
        //    string coursName = "Learn C# for Beginners Crash Course";
        //    string message = "Welcom to ";

        //    Console.WriteLine(coursName[0]);
        //    Console.WriteLine(coursName[7]);

        //    for(int i = 13; i < 21; i++)
        //    {
        //        Console.Write(coursName[i]);
        //    }
        //    Console.WriteLine();
            
        //}

        //==========Sec 9 video 125============

        static void Main(string[] args)
        {
            //0         1         2         3  
            //0123456789012345678901234567890123456789
            string coursName = "Learn C# for Beginners Crash Course";
            string message = "Welcom to ";

            Console.WriteLine(coursName[0]);
            Console.WriteLine(coursName[7]);

            for (int i = 13; i < coursName.Length; i++)
            {
                Console.Write(coursName[i]);
            }
            Console.WriteLine();
            Console.WriteLine(coursName.Length);

        }
    }
}
