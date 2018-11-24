using System;
using System.IO;


namespace SimpleFileLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number log to file:");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Robin\log.txt", input);

            Console.WriteLine("Reading from same file:");
            string fetch = File.ReadAllText(@"C:\Users\RobinDT\log.txt");
            Console.WriteLine(fetch);

            Console.ReadLine();
        }
    }
}
