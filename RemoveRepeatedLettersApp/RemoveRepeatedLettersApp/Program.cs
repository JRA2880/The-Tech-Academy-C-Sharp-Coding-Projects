//Programmer: John R. Adams
//Date: 9-10-2019
//
//Task: Given a string, remove any repeated letters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveRepeatedLettersApp
{
    class Program
    {

        static void Main()
        {
            string word1 = RemoveRepeatedLetters("Jabberwacky");
            string word2 = RemoveRepeatedLetters("Ninja");
            string word3 = RemoveRepeatedLetters("Racoon");
            string word4 = RemoveRepeatedLetters("There once was a man named Othello, who was a fine fellow...");
            string word5 = RemoveRepeatedLetters("You can learn to code anywhere in the world!");

            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.WriteLine(word3);
            Console.WriteLine(word4);
            Console.WriteLine(word5);
        }
        static string RemoveRepeatedLetters(string word)
        {
            string newWord = "";

            foreach (char character in word)
            {
                if (newWord.IndexOf(character) == -1)
                {
                    newWord += character;
                }
            }
            return newWord;
        }

    }

}


