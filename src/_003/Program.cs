using System;
using System.Numerics;

namespace _003
{
    class Program
    {
        //Fermat's little theorem
        static bool IsPrime(BigInteger n)
        {
            if (n == 1 || n == 2 || n == 3)
                return true;

            BigInteger a = n - 2;

            if (2 <= a && a <= (n - 1))
            {
                //int ap = Math.Pow(a, n);
                return (BigInteger.Pow(a, (int)n) - a) % (BigInteger)n == 0;
            }
            return false;
        }

        //Simple
        static bool IsPrime2(int n)
        {
            for (int i = n - 1; i > 1; i--)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        
        public static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!IsSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }
        private static bool IsSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        static BigInteger GetAnswer(BigInteger number)
        {
            BigInteger root = Sqrt(number) - 1;

            for (BigInteger i = root; i > 0; i--)
            {
                if (number % i == 0 && i * i != number)
                    if (IsPrime2((int)i))
                        return i;
            }



            /*while (i > 0)
            {
                if (number % i == 0)
                    if (IsPrime(i))
                        return i;

                i--;
            }*/

            return -1;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Project Euler. Verloka Vadim, 2019");
            Console.WriteLine(new string('-', 50));

            Console.Write("Enter number: ");
            bool result = BigInteger.TryParse(Console.ReadLine(), out BigInteger number);

            Console.WriteLine($"Largest prime factor of the number {number} is {GetAnswer(number)}");

            /*if (result)
            {
                Console.WriteLine($"Number {number} is {(IsPrime(number) ? "" : "not ")}prime (Fermat's little theorem)"); 
                Console.WriteLine($"Number {number} is {(IsPrime(number) ? "" : "not ")}prime (simple)"); 
            }
            else
                Console.WriteLine("Incorrect number");*/

            Console.Read();
        }
    }
}
