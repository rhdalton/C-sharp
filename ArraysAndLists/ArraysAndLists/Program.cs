using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] str_array = { "Julie Cook", "Mark Thompson", "Sara Thomas", "Marie Murphy", "Dennis Robinson",
                                "Jane Coleman", "Eric James", "Rose Lopez", "Stephanie Henderson", "Russell Griffin" };

        Console.WriteLine("Enter a number to see if the person is in the Array:");
        string input_num = Console.ReadLine();

        try
        {
            int key = Convert.ToInt16(input_num);
            Console.WriteLine(str_array[key] + " is in the Array!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Sorry, your input was not a number.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Sorry, that index doesn't exist.");
        }
        catch
        {
            Console.WriteLine("Something went wrong!");
        }

        Console.WriteLine("");

        int[] int_array = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800 };

        Console.WriteLine("Enter a number:");
        input_num = Console.ReadLine();

        try
        {
            int key = Convert.ToInt16(input_num);
            Console.WriteLine(key + "! is equal to " + int_array[key]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Sorry, your input was not a number.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Sorry, that index doesn't exist.");
        }
        catch
        {
            Console.WriteLine("Something went wrong!");
        }

        Console.WriteLine("");
        List<string> str_list = new List<string>()
            { "Julie Cook", "Mark Thompson", "Sara Thomas", "Marie Murphy", "Dennis Robinson",
              "Jane Coleman", "Eric James", "Rose Lopez", "Stephanie Henderson", "Russell Griffin" };

        Console.WriteLine("Enter a number to see if the person is in the List:");
        input_num = Console.ReadLine();

        try
        {
            int key = Convert.ToInt16(input_num);
            Console.WriteLine(str_array[key] + " is in the List!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Sorry, your input was not a number.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Sorry, that index doesn't exist.");
        }
        catch
        {
            Console.WriteLine("Something went wrong!");
        }

        Console.ReadLine();
    }
}