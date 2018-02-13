using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveLetters
{
    class WordList
    {
        public static List<string> GetWordList()
        {
            List<string> wordList = new List<string>();
            string word;

            Console.WriteLine("Enter your words (or ENTER to finish):");

            do
            {
                word = Console.ReadLine();
                wordList.Add(word);
            } while (word != "");

            return wordList;
        }

        public static string PrintWordList(List<string> wordList)
        {
            string wordListString = "";

            for (int i = 0; i < wordList.Count; i++)
            {
                wordListString += wordList[i] + " ";
            }
            return wordListString;
        }

        public static string PrintFiveLetterWords(List<string> wordList)
        {
            string fiveLetterwords = "";

            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i].Length == 5)
                {
                    fiveLetterwords += wordList[i] + " ";
                }
            }
            return fiveLetterwords;
        }
    }
}
