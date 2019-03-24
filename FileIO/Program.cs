using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
         
                //this will make a string and call it testFileName and assign it to "Test.txt"
                string testFileName = "Test.txt";


                //if a file called what testFileName is assigned to exists, run the code in here
                if (File.Exists(testFileName))
                {
                    //this will make a string and call it fileContents and set it to what the "Test.txt" file has in it.
                    string fileContents = File.ReadAllText(testFileName);

                    //this will write out what the fileContents string has in it
                    Console.WriteLine($"Hello, again, your last input was: {fileContents}");
                }
                string a;
                Console.WriteLine("Please type in something.");
                //this will assign the "a" string to what the user typed
                a = Console.ReadLine();
                //this will write what a has in it to a text file, and call the text file "Test.txt"
                File.WriteAllText(@"Test.txt", a);
            
        }
    }
}
