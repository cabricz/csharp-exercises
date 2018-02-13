using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = WordList.GetWordList();

            Console.WriteLine(WordList.PrintWordList(wordList));
            Console.WriteLine(WordList.PrintFiveLetterWords(wordList));
            Console.ReadLine();
        }
    }
}
