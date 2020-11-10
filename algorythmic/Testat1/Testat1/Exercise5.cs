using System;
using System.Collections.Generic;
using System.Text;

namespace Testat1
{
    public static class Exercise5
    {
        private static int _count;
        public static void Solve()
        {
            _count = 0;
            Console.WriteLine("----------Start Exercise 5-----------");

            Console.WriteLine("Before Solving: O(log(n)) //log with base 2");
            var input = 8;
            Console.WriteLine($"Input: {input}");
            ProcRec1(input);
            Console.WriteLine($"Output: {_count}");
            Console.WriteLine("----------Finished Exercise 5-----------");
        }

        private static void ProcRec1(int n)
        {
            if (n <= 1)
                return;
            _count++;
            ProcRec1(n / 2);
        }
    }
}
