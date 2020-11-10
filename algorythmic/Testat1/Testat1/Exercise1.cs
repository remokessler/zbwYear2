using System;
using System.Collections.Generic;
using System.Linq;

namespace Testat1
{
    public static class Exercise1
    {
        public static void Solve()
        {
            Console.WriteLine("----------Start Exercise 1-----------");

            var input = "Reverse Me";
            Console.WriteLine($"Input: {input}");
            var reversed = Reverse(input);
            Console.WriteLine($"Output: {reversed}");
            Console.WriteLine("----------Finished Exercise 1-----------");
        }

        public static string Reverse(string word) => Reverse(new Queue<char>(word));

        private static string Reverse(Queue<char> word)
        {
            if (word.Count <= 0)
                return string.Empty;

            var letter = word.Dequeue();
            return Reverse(word) + letter;
        }
    }
}
