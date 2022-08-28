using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    internal class Q1
    {
        public static void M()
        {
            List<int> list = new List<int>() { 9, 7, 3, 2, 5, 6 };
            var result = from i in list
                         orderby i ascending
                         select i;
            //display square of list item
            var result1 = from i in list
                          let k = i * i * i
                          where k > 100 && k < 1000
                          select k;
            list[0] =9;
            foreach (var i in result1)
                Console.WriteLine(i);

        }
    }

}

