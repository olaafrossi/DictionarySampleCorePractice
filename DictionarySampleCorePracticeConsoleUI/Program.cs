using System;
using System.Collections.Generic;

namespace DictionarySampleCorePracticeConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetName();
            TestDics();
            Console.WriteLine("Hello World!");
        }

        private static void GetName()
        {
            Dictionary<int, string> employeeDictionary = new Dictionary<int, string>();
            employeeDictionary[1] = "John";
            employeeDictionary[2] = "Sally";
            employeeDictionary[3] = "Johnny";
            employeeDictionary[4] = "Kelly";

            Console.WriteLine("punch in 1-4 for ID and get a name");
            string input = string.Empty;
            input = Console.ReadLine();
            int employeeID = Int32.Parse(input); 
            Console.WriteLine(employeeDictionary[employeeID]);
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
        }

        private static void TestDics()
        {
            Dictionary<int, string> importantYears = new Dictionary<int, string>();
            importantYears[1980] = "Olaaf's Birthyear";
            importantYears[1969] = "Man on the moon";
            importantYears[1776] = "declration of independance";
            Console.WriteLine($"{importantYears[1980]}");

            foreach (var variable in importantYears.Keys)
            {
                Console.WriteLine($"{variable}");
            }
        }
    }
}
