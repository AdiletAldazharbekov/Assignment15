using System;
using System.Collections.Generic;
using DictionaryLibrary;

namespace Assignment15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dictionary = new MyDictionary();
            dictionary.Add("1", "First");
            dictionary.Add("2", "Second");
            dictionary.Print();

        }

    }
}
