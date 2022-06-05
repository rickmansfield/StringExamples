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

        //static void Main(string[] args)
        //{
        //    //0         1         2         3  
        //    //0123456789012345678901234567890123456789
        //    string coursName = "Learn C# for Beginners Crash Course";
        //    string message = "Welcom to ";

        //    Console.WriteLine(coursName[0]);
        //    Console.WriteLine(coursName[7]);

        //    for (int i = 13; i < coursName.Length; i++)
        //    {
        //        Console.Write(coursName[i]);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine(coursName.Length);

        //}

        //==================Sec 9 video 127=============
        //static void Main(string[] args)
        //{
        //                  0         10's      20's      30's 
        //                  0123456789012345678901234567890123456789
        //string coursName = "Learn C# for Beginners Crash Course";
        //int position;

        /* position = coursName.IndexOf(" c", StringComparison.OrdinalIgnoreCase);*/// treats the characters in the strings to compare as if they were converted to uppercase using the conventions of the invariant culture, and then performs a simple byte comparison that is independent of language.

        /* position = coursName.IndexOf(" c", StringComparison.CurrentCultureIgnoreCase);*///ignores case & used when strings are linguistically 
                                                                                           // see alos https://docs.microsoft.com/en-us/dotnet/api/system.stringcomparison?view=net-6.0
                                                                                           //Console.WriteLine(position);
                                                                                           //}

        //==================Sec 9 video 128=============
        //static void Main(string[] args)
        //{
        //    //                  0         10's      20's      30's 
        //    //                  0123456789012345678901234567890123456789
        //    string coursName = "Learn C# for Beginners Crash Course";
        //    int position = -1;

        //    //position = coursName.IndexOf(" c", StringComparison.OrdinalIgnoreCase);
        //    //position = coursName.LastIndexOf(" c", StringComparison.OrdinalIgnoreCase);
        //    do
        //    {

        //    position = coursName.IndexOf(" c", position + 1, StringComparison.OrdinalIgnoreCase);
        //    Console.WriteLine(position);
        //    }
        //    while (position != -1);
        //}

        //==================Sec 9 video 129==========================
        static void Main(string[] args)
        {
            //                  0         10's      20's      30's 
            //                  0123456789012345678901234567890123456789
            string courseName = "Learn C# for Beginners Crash Course";
            int position = -1;

            //position = coursName.IndexOf(" c", StringComparison.OrdinalIgnoreCase);
            //position = coursName.LastIndexOf(" c", StringComparison.OrdinalIgnoreCase);
            do
            {

                position = courseName.IndexOf(" c", position + 1, StringComparison.OrdinalIgnoreCase);
                if (position != -1)
                {
                    courseName = ReplaceByIndex(courseName, position, " c".Length, " Java");
                    Console.WriteLine(courseName);
                }
            }
            while (position != -1);
            string fixedString = courseName.Replace(" Java", " C");
            Console.WriteLine(fixedString);
        }
        private static string ReplaceByIndex(string original, int start, int length, string replacement)
        {
            string newString = original.Remove(start, length);
            return newString.Insert(start, replacement);
        }
    }
}


