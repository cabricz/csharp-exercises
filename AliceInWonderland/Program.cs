using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of " +
                "sitting by her sister on the bank, and of having nothing to do: " +
                "once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of " +
                "a book,' thought Alice 'without pictures or conversation?'".ToLower();

            Console.WriteLine("Type string to search?");
            string search = Console.ReadLine().ToLower();

            while (search != "")
            {
                Console.WriteLine(alice.Contains(search));

                Console.WriteLine("Type string to search?");
                search = Console.ReadLine().ToLower();
            }
        }
    }
}
