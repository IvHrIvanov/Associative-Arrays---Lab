using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().ToLower().Split(" ");

            Dictionary<string, int> savedWords = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (!savedWords.ContainsKey(currentWord))
                {
                    savedWords.Add(currentWord, 0);
                }
                savedWords[currentWord] += 1;
            }

            foreach (var item in savedWords)
            {

                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");
                }

            }
        }
    }
}