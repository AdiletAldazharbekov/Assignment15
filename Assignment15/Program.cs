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

            MyDictionary dictionary1 = new MyDictionary();
            dictionary1.Add("1", "Adilet");
            dictionary1.Add("2", "Kani");
            dictionary1.Add("3", "Dani");
            
    
          
                Console.WriteLine(dictionary1.GetValue("1"));
                Console.WriteLine(dictionary1.GetValue("2"));
               
          
        }

    }
}
