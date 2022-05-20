using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coursName = "Learn C# for Beginners Crash Course";
            string message = "Welcom to ";

            // Concatenate courseName and message to create a new string
            string fullMessage = message + coursName;
            Console.WriteLine(fullMessage);

            // Use string interpolation 
            string fullMessage2 = $"{message}{coursName}";
            Console.WriteLine(fullMessage2);

            // Use Composite Formatting with mehtods that support it
            Console.WriteLine("Hello, and {0} the {1}", message, coursName );

            for (int i = 0; i < coursName.Length; i++)
            {
                char character = coursName[i];
                Console.WriteLine(character);
            }
        }
    }
}
