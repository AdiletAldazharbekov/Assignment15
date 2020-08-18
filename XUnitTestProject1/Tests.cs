using System;
using Xunit;
using DictionaryLibrary;

namespace MyDictionaryTest
{
    public class Tests
    {
        [Fact]        
        public void InitializingTest()
        {
            var expected = 0;

            var actual = new MyDictionary().Lenght();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTest()
        {
            var expected = 2;
            var dictionary = new MyDictionary();
            dictionary.Add("1", "First");
            dictionary.Add("2", "Second");
            dictionary.Add("1", "Third");
            var actual = dictionary.Lenght();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetValueTest()
        {
            
            
            var dictionary = new MyDictionary();
            dictionary.Add("1", "First");
            dictionary.Add("2", "Second");
            
            var expected = "First";
            var actual = dictionary.GetValue("1");
            Assert.Equal(expected, actual);

            var expected2 = "Ключ \"3\" в базе не существует, попробуйте другой ключ.";
            var actual2 = dictionary.GetValue("3");
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void RemoveTest()
        {
            var expected = 2;
            var dictionary = new MyDictionary();
            dictionary.Add("1", "First");
            dictionary.Add("2", "Second");
            dictionary.Add("3", "Third");
            dictionary.Remove("2");
            var actual = dictionary.Lenght();

            Assert.Equal(expected, actual);
            
            dictionary.Remove("2");
            var expected2 = 2;
            var actual2 = dictionary.Lenght();
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void PrintTest()
        {
            var expected = 2;
            var dictionary = new MyDictionary();
            dictionary.Add("1", "First");
            dictionary.Add("2", "Second");
            dictionary.Print();
            var actual = dictionary.Lenght();

            Assert.Equal(expected, actual);
        }
    }
}
