using System;
using System.Collections.Generic;
using System.Linq;
// 5. дан словарь (ключ - целое, значение - целое). Подсчитать сумму ключей неотрицательных значений
namespace DictionaryTask1
{
    class Dictionary
    {
        public void NonNegKeySum(IDictionary<int, int> dc) // Counting sum of non-negative keys
        {
            int keysum = 0;
            for (int i = 0; i < dc.Count; i++)
            {
                if (dc.ElementAt(i).Key >= 0)
                    {
                    keysum += dc.ElementAt(i).Key;
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

            IDictionary<int, int> dc = new Dictionary<int, int>();
            
            Console.WriteLine("Enter a number of elements in dictionary:");

            int nel = int.Parse(Console.ReadLine()); //user defines the number of elements in the dictionary

            Console.WriteLine();
            Console.WriteLine("The dictionary is:");

            int d;
            int k;
            Random r = new Random();

            for (int i = 0; i < nel; i++)
            {
                do {k = r.Next(-1000, 1000);}
                while (dc.ContainsKey(k)); 
                d = r.Next(-1000, 1000);
                dc.Add(k, d);
                Console.Write(k + ": ");
                Console.WriteLine(d);
            }

            Dictionary dc1 = new();
            dc1.NonNegKeySum(dc);

        }
    }
}
