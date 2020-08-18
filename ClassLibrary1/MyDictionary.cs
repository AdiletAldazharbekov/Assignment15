using System;

namespace DictionaryLibrary
{
    public class MyDictionary
    {
        private string[,] myDictionary = new string[0, 0];

        public int Lenght() => myDictionary.GetLength(0);

        public void Add(string id, string name)
        {
            var isTrue = true;
            for (int i = 0; i < myDictionary.GetLength(0); i++)
            {
                if (id == myDictionary[i, 0])
                {
                    Console.WriteLine($"Ключ \"{id}\" существует в базе, попробуйте другой ключ.");
                    isTrue = false;
                    break;
                }
            }

            if (isTrue)
            {
                var newMyDictionary = new string[myDictionary.GetLength(0) + 1, 2];

                for (int i = 0; i < myDictionary.GetLength(0); i++)
                {
                    newMyDictionary[i, 0] = myDictionary[i, 0];
                    newMyDictionary[i, 1] = myDictionary[i, 1];
                }
                newMyDictionary[newMyDictionary.GetLength(0) - 1, 0] = id;
                newMyDictionary[newMyDictionary.GetLength(0) - 1, 1] = name;

                myDictionary = newMyDictionary;
            }
        }

        public string GetValue(string id)
        {
            var name = $"Ключ \"{id}\" в базе не существует, попробуйте другой ключ.";
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
            var isTrue = true;
            for (int i = 0; i < myDictionary.GetLength(0); i++)
            {
                if (id == myDictionary[i, 0])
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue) Console.WriteLine($"Ключ \"{id}\" в базе не существует и не был удален, попробуйте другой ключ.");
            else
            {
                var newMyDictionary = new string[myDictionary.GetLength(0) - 1, 2];
                for (int j = 0, i = 0; i < myDictionary.GetLength(0); i++)
                {
                    if (id == myDictionary[i, 0]) continue;
                    newMyDictionary[j, 0] = myDictionary[i, 0];
                    newMyDictionary[j, 1] = myDictionary[i, 1];
                    j++;
                }
                myDictionary = newMyDictionary;
            }
        }

        public void Print()
        {
            for (int i = 0; i < myDictionary.GetLength(0); i++)
                Console.WriteLine($"{myDictionary[i, 0]}\t{myDictionary[i, 1]}");
        }
    }
}