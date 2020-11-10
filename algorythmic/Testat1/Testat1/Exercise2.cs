using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testat1
{
    public static class Exercise2
    {
        public static void Solve()
        {
            Console.WriteLine("----------Start Exercise 2-----------");

            var input = 40;
            Console.WriteLine($"Input: {input}");
            var output = string.Join(", ", GetFibonacci(input));
            Console.WriteLine($"Output: {output}");
            Console.WriteLine("----------Finished Exercise 2-----------");
        }

        private static IEnumerable<long> GetFibonacci(int count)
        {
            var list = new List<long>();

            for (int i = 0; i < count; i++)
            {
                if (i == 0 || i == 1)
                {
                    list.Add(1);
                }
                else
                {
                    long fibonacci = list.Last() + list[list.Count - 2];
                    list.Add(fibonacci);
                }
            }
            return list;
        }
    }
}
