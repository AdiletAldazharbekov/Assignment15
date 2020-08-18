using System;
using System.Collections.Generic;
using DictionaryLibrary;

namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {


            var dictionary = new MyDictionary();
            dictionary.Add("1", "First");
            dictionary.Add("2", "Second");
            dictionary.Add("1", "Third");
            dictionary.Add("3", "Third");

            Console.WriteLine();

            Console.WriteLine(dictionary.GetValue("3"));

            Console.WriteLine();
            Console.WriteLine(dictionary.GetValue("4"));

            Console.WriteLine();

            dictionary.Remove("3");
            Console.WriteLine();

            dictionary.Remove("5");


            Console.WriteLine();
            dictionary.Print();

        }

    }
}
