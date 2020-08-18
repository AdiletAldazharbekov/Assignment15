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
            var actual = dictionary.Lenght();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetValueTest()
        {
            var expected = "First";
            var dictionary = new MyDictionary();
            dictionary.Add("1", "First");
            
            var actual = dictionary.GetValue("1");

            Assert.Equal(expected, actual);
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
