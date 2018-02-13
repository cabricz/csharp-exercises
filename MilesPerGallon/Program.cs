using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = int.Parse(Console.ReadLine());

            Console.WriteLine("How many gallons of gas have you used?");
            int gas = int.Parse(Console.ReadLine());

            int milesPerGallon = miles / gas;

            Console.WriteLine(milesPerGallon);

            Console.ReadLine();
        }
    }
}
