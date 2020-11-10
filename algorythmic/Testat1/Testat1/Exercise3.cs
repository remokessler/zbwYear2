using System;
using System.Collections.Generic;
using System.Text;

namespace Testat1
{
    public static class Exercise3
    {
        public static void Solve()
        {
            Console.WriteLine("----------Start Exercise 3-----------");

            var input = 5;
            Console.WriteLine($"Input: {input} , Dest, Source, Help");
            TowersOfHanoi(input, "Source", "Dest", "Help");
            Console.WriteLine("----------Finished Exercise 3-----------");
        }

        private static void TowersOfHanoi(int plate, string source, string destination, string help)
        {
            if(plate > 0)
            {
                TowersOfHanoi(plate - 1, source, help, destination);
                Console.WriteLine($"Move Plate {plate} from {source} to {destination}");
                TowersOfHanoi(plate -1, help, destination, source);
            }
        }
    }
}
