// Though the solution is named Fibonacci it is actually about calculating the Factorial value :)
using System;
namespace Factorial
{
    public class Program
    {
        long fact = 1;
        public long GetFactorial(long n)
        {
            if (n > 1)
            {
                fact = n * GetFactorial(n - 1);
            }
            return fact;
        }

        static void Main(string[] args)
        {
            Program num = new();
            Console.WriteLine("Enter a number > 0");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Factorial value is: {0}", num.GetFactorial(n));
        }

    }
}
