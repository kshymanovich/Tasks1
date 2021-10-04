using System;
namespace Factorial
{
    public class Program
    {
        public long GetFactorial(long n)
        {
            if (n > 1)
            {
                n = n * GetFactorial(n - 1);
                return n;
            }
            else return 1;
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
