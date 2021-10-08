using System;
using System.Collections;
// 5. дан словарь (ключ - целое, значение - целое). Подсчитать сумму ключей неотрицательных значений
namespace DictionaryTask1
{
    class Dictionary
    {
        public void NonNegKeySum(SortedList dc, int nel, int keysum = 0)
        {
            for (int i = 0; i < nel; i++)
            {
                if ((int)dc.GetByIndex(i) >= 0)
                    {
                        keysum += (int)dc.GetKey(i);
                    }
            }
        Console.WriteLine("Sum of the keys of non-negative dictionary elements is: " + keysum);
        }
    }



   
    class Program
    {
        static void Main(string[] args)
        {
            //creating dictionary of numeric elements
            SortedList dc = new();

            Console.WriteLine("Enter a number of elements in dictionary:");

            int nel = int.Parse(Console.ReadLine()); //user defines the number of elements in the dictionary

            Console.WriteLine();
            Console.WriteLine("The dictionary is:");

            int d;
            int k;
            Random r = new Random();
            
            for (int i = 0; i < nel; i++)
            {
                k = r.Next(-1000, 1000);
                d = r.Next(-1000, 1000);
                dc.Add(k, d);
                Console.Write(k + ": ");
                Console.WriteLine(d);
            }

            Dictionary dc1 = new();
            dc1.NonNegKeySum(dc, nel);

        }
    }
}
