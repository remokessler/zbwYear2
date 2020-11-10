using System;
using System.Collections.Generic;
using System.Text;

namespace Testat1
{
    public static class Exercise6
    {
        private static int _count;
        public static void Solve()
        {
            _count = 0;
            Console.WriteLine("----------Start Exercise 6-----------");

            Console.WriteLine("Before Solving: O(2 * n) //log with base 2");
            var input = 32;
            Console.WriteLine($"Input: {input}");
            ProcRec2(input);
            Console.WriteLine($"Output: {_count}");

            Console.WriteLine("After Solving: O(2 * n - 1) //log with base 2");
            Console.WriteLine("----------Finished Exercise 6-----------");
        }

        private static void ProcRec2(int n)
        {
            _count++;
            if (n <= 1)
                return;
            
            ProcRec2(n / 2);
            ProcRec2(n / 2);
        }
    }
}
