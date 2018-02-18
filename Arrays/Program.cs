using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < array.Count(); i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
