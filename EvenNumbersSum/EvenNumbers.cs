using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbersSum
{
    class EvenNumbers
    {
        public static List<int> GetRandomNumberList()
        {
            Random rnd = new Random();
            List<int> numberList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int number = rnd.Next(1, 11);
                numberList.Add(number);
            }
            return numberList;
        }

        public static int AddEvenNumbers(List<int> numberList)
        {
            int evenSum = 0;

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(String.Format("numberlist[{0}]: {1}", i, numberList[i]));
                if (numberList[i] % 2 == 0)
                {
                    evenSum += numberList[i];
                    Console.WriteLine("evenSum: " + evenSum);
                }
            }
            return evenSum;
        }
    }
}
