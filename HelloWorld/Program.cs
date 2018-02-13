using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> x = new List<string>();

            x.Add("one");
            x.Add("two");
            x.Add("three");

            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine(x[i].Length);
            }

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
