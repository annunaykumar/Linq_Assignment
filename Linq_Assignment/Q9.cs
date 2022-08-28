using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    internal class Q9
    {
        public static void CountEvenNumber()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int evenNumbers = numbers.Count(n => n % 2 == 0);
            var result = (from m in numbers
                          where m % 2 == 0
                          select m).ToList();
            foreach (var item in result)
                Console.WriteLine(item);
            

            Console.WriteLine("There are {0} Even numbers in the list.", evenNumbers);
        }
    }
}
