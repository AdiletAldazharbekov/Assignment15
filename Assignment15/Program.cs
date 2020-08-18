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

            Console.WriteLine(dictionary.GetValue("3"));

            dictionary.Remove("3");

            dictionary.Print();

        }

    }
}
