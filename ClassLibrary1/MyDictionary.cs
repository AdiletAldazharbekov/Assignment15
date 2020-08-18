using System;
using System.Collections.Generic;

namespace DictionaryLibrary
{
    public class MyDictionary
    {
        string [,] myDictionary = new string[0, 0];
        public int Lenght() => myDictionary.GetLength(0);

        public void Add(string id, string name)
        {
            var newMyDictionary = new string[myDictionary.GetLength(0)+1, 2];
            for (int i = 0; i < newMyDictionary.GetLength(0); i++)
            {
                newMyDictionary[i, 0] = id;
                newMyDictionary[i, 1] = name;
            }
            myDictionary = newMyDictionary;
        }




        public string GetValue(string id)
        {
            var name = "Error";
            for (int i = 0; i < myDictionary.GetLength(0); i++)
            {
                if (id == myDictionary[i, 0])
                {
                    name = myDictionary[i, 1];
                    break;
                }
            }

            return name;
        }
        public void Remove(string id)
        {
            var newMyDictionary = new string[myDictionary.GetLength(0) - 1, 2];
            
            for (int j = 0, i = 0; i < myDictionary.GetLength(0); i++)
            {
               
                if (id == myDictionary[i, 0])
                {
                    continue; 
                }
                else
                {
                    newMyDictionary[j, 0] = myDictionary[i, 0];
                    newMyDictionary[j, 1] = myDictionary[i, 1];
                    j++;
                }
            }
            myDictionary = newMyDictionary;
        }
        public void Print()
        {
            foreach (var i in myDictionary)
            {
                Console.WriteLine(i);
            };
        }
    }
}
