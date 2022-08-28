using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 98, 23, 87, 34, 76, 45, 32, 74 };
            //filter even values from array
            var result = from i in n
                         where i % 2 == 0
                         select i;
            //filter odd values grater than 50
            result = from i in n
                     where i > 2
                     select i;
            //sort array elemnts
            result = from i in n
                     orderby i
                     select i;
            result = from i in n
                     where i % 2 == 0
                     orderby i descending
                     select i;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.Clear();

            // Q1.M();
            // Q2.M();
             Q3.M();
            // Q4.M();
            //Q5.M();
           // Q9.CountEvenNumber();
            Console.ReadLine();
        }
    }
    
}
