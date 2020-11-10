using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Move(4, "A", "B", "C");
            Console.Read();
        }

        private static void Move(int plates, string start, string help, string destination)
        {
            if (plates == 1)
            {
                Console.WriteLine($"Move plate from {start} to {destination}k");
            }
            else
            {
                Move(plates - 1, start, destination, help);
                Console.WriteLine($"Move plate from {help} to {destination}");
                Move(plates - 1, help, start, destination);
            }
        }
    }
}
