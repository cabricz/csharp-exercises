using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height:");
            float y = float.Parse(Console.ReadLine());

            float area = x * y;

            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadLine();

        }
    }
}
