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
            var expected = 1;
            var dictionary = new MyDictionary();
            dictionary.Add("1", "Adilet");
            var actual = dictionary.Lenght();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetValueTest()
        {
            var expected = "Adilet";
            var dictionary = new MyDictionary();
            dictionary.Add("1", "Adilet");
            
            var actual = dictionary.GetValue("1");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveTest()
        {
            var expected = 2;
            var dictionary = new MyDictionary();
            dictionary.Add("1", "Adilet");
            dictionary.Add("2", "Kani");
            dictionary.Add("3", "Dani");
            dictionary.Remove("2");
            var actual = dictionary.Lenght();

            Assert.Equal(expected, actual);
        }
    }
}
