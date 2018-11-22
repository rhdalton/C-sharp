using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string[] str_array = { "This is string one.", "This is string two.", "This is string three.", "This is string four.", "This is string five." };

        Console.WriteLine("Input some random text:");
        string usr_text = Console.ReadLine();

        for (int i = 0; i < str_array.Length; i++)
        {
            str_array[i] = str_array[i] + " " + usr_text;
        }

        foreach (string str in str_array)
        {
            Console.WriteLine(str);
        }

        List<int> rnd_list = new List<int>();
        Random rnd = new Random();
        int rnd_int;

        Console.WriteLine("");

        Console.WriteLine("This loop will contine outputting random numbers until it reaches a number greater than 80.");
        do
        {
            rnd_int = rnd.Next(1, 100);
            string rnd_int_str = (rnd_int > 80) ? rnd_int + " - Loop ending!\n" : rnd_int + "\n";
            Console.Write(rnd_int_str);

            Thread.Sleep(500);
        }
        while (rnd_int <= 80);

        Console.WriteLine("");

        List<string> fruit_list = new List<string>() { "apple", "orange", "banana", "pear", "peach", "mango", "pineapple", "strawberry" };
        Console.WriteLine("This is a list of fruit:");
        foreach (string f in fruit_list)
        {
            Console.Write(f + ", ");
        }
        Console.WriteLine("\nChoose and enter the name of a fruit:");
        string fruit_input = Console.ReadLine();
        int key = -1;

        for (int k = 0; k < fruit_list.Count; k++)
        {
            if (fruit_list[k] == fruit_input.ToLower())
            {
                key = k;
                break;
            }
        }
        if (key >= 0)
        {
            Console.WriteLine("Your fruit has an index of " + key + " in the fruit list.");
        }
        else
        {
            Console.WriteLine("Your fruit is not in the fruit list.");
        }

        Console.WriteLine("");

        List<string> name_list = new List<string>() { "John", "David", "Bob", "Joe", "David", "Chris", "David", "Joe", "Bill", "Bob" };
        Console.WriteLine("This is a list of names:");
        foreach (string f in name_list)
        {
            Console.Write(f + ", ");
        }
        Console.WriteLine("\nChoose and enter a name:");
        string name_input = Console.ReadLine();
        List<int> key_list = new List<int>();

        for (int m = 0; m < name_list.Count; m++)
        {
            if (name_list[m].ToLower() == name_input.ToLower())
            {
                key_list.Add(m);
            }
        }

        if (key_list.Count.Equals(0))
        {
            Console.WriteLine("Your name is not in the name list.");
        }
        else
        {
            Console.Write("Your name is matched on indices: ");
            foreach (int n in key_list)
            {
                Console.Write(n + ", ");
            }
        }

        Console.WriteLine("\n");

        Console.WriteLine("Printing the list of names:");
        List<string> name_list_2 = new List<string>();
        List<string> count_list = new List<string>() { "", "once", "twice", "three times", "four times" };

        foreach (string o in name_list)
        {
            Console.Write(o);
            int count = 0;
            foreach (string p in name_list_2)
            {
                if (p == o)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.Write(" - This name has appeared " + count_list[count] + " before.");
            }

            name_list_2.Add(o);

            Console.Write("\n");
            Thread.Sleep(500);
        }

        Console.ReadLine();
    }
}