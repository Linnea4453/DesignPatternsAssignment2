using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2.Facade
{
    public class Word
    {
        private List<char> one = new();
        private List<char> two = new();
        private List<char> three = new();
        private List<char> four = new();
        private List<char> five = new();

        public void SaveWord()
        {
            string input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);
            }
            else
            {
                one.Add(input[0]);
                two.Add(input[1]);
                three.Add(input[2]);
                four.Add(input[3]);
                five.Add(input[4]);
            }
        }

        public void LoadWord()
        {
            char[] word = { one.Last(), two.Last(), three.Last(), four.Last(), five.Last() };
            Console.WriteLine(word);
        }
    }
}