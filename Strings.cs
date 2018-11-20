using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string str1 = "To be or not";
            string str2 = "to be, that";
            string str3 = "is the question.";

            string concat = str1 + " " + str2 + " " + str3;

            Console.WriteLine(concat);
            Console.WriteLine("");
            Console.WriteLine(concat.ToUpper());

            Console.WriteLine("");
            StringBuilder sb = new StringBuilder();

            sb.Append("Two roads diverged in a yellow wood,\n");
            sb.Append("And sorry I could not travel both\n");
            sb.Append("And be one traveler, long I stood\n");
            sb.Append("And looked down one as far as I could\n");
            sb.Append("To where it bent in the undergrowth;\n\n");
            sb.Append("Then took the other, as just as fair,\n");
            sb.Append("And having perhaps the better claim,\n");
            sb.Append("Because it was grassy and wanted wear;\n");
            sb.Append("Though as for that the passing there\n");
            sb.Append("Had worn them really about the same,");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}