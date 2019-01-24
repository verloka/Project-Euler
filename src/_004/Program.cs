using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static bool IsPalindrome(int i)
        {
            string num = i.ToString();
            char[] rnum = num.ToCharArray();
            Array.Reverse(rnum);
            string nnum = new string(rnum);
            return num == nnum;
        }

        static Tuple<int, int, int> GetAnswer()
        {
            int left = 999;
            int right = 999;
            List<Tuple<int, int, int>> palindromes = new List<Tuple<int, int, int>>();

            for (int i = left; i > 99; i--)
                for (int j = right; j > 99; j--)
                {
                    int num = i * j;
                    if (IsPalindrome(num))
                        palindromes.Add(new Tuple<int, int, int>(i, j, num));
                }

            

            return palindromes.OrderByDescending(x => x.Item3).ToList()[0];
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            var a = GetAnswer();

            Console.WriteLine($"Answer: {a.Item1} х {a.Item2} = {a.Item3}");

            Console.ReadLine();
        }
    }
}
