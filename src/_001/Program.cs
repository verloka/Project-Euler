using System;
using System.Linq;

namespace _001
{
    class Program
    {
        static long GetAnswer(int top)
        {
            long ans = 0;

            //create array with nuimbers and fill him
            long[] numbers = new long[top];
            for (int i = 0; i < top; i++)
                numbers[i] = i;

            //get collection with right numbers
            var coll = (from item in numbers
                        where item % 3 == 0 || item % 5 == 0
                        select item);

            //calculate sum of this numbers
            ans = coll.Sum();

            return ans;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("BProject Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));


            Console.Write("Enter top: ");
            bool result = int.TryParse(Console.ReadLine(), out int top);

            if (result)
                Console.WriteLine($"Answer: {GetAnswer(top)}");
            else
                Console.WriteLine("Wrong 'top' number!");

            Console.ReadLine();
        }
    }
}
