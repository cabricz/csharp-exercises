﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = EvenNumbers.GetRandomNumberList();
            int evenNumbers = EvenNumbers.AddEvenNumbers(numberList);

            Console.WriteLine(evenNumbers);
            Console.ReadLine();
        }
    }
}
