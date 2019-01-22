using System;
using System.Collections.Generic;
using System.Linq;

namespace _002
{
    class Program
    {
        static long GetAnswer()
        {
            List<int> numbers = new List<int>
            {
                1,
                2
            };

            int i = 2;
            int current = 0;

            while (current < 4000000)
            {
                current = numbers[i - 1] + numbers[i - 2];
                numbers.Add(current);
                i++;
            }

            //get collection with right numbers
            var coll = (from item in numbers
                        where item % 2 == 0
                        select item);

            //calculate sum of this numbers
            return coll.Sum();
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"Answer: {GetAnswer()}");

            Console.ReadLine();
        }
    }
}
