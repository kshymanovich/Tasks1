using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
//дан словарь (ключ - строка, значение - строка). получить список ключей, для которых в значении есть символ "s"

namespace Dictionary2
{
    class Dictionary
    {
        public void SKeys(IDictionary<string, string> dc) // get array of keys of elements containing "s"
        {
            ArrayList keylist = new();
            int b = 0;
            string d;
            for (int i = 0; i < dc.Count; i++)
            {
                d = dc.ElementAt(i).Value;
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[j] == 's')
                    {
                        keylist.Add((object)dc.ElementAt(i).Key);
                        b++;
                        break;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Keys of s-consuming dictionary values:");
            for (int j = 0; j < b; j++)
            {
                Console.WriteLine(keylist[j]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //creating dictionary of string elements
            IDictionary<string, string> dc = new Dictionary<string, string>();

            Console.WriteLine("Enter a number of elements in dictionary:");

            int nel = int.Parse(Console.ReadLine()); //user defines the number of elements in the dictionary

            Console.WriteLine();
            
            string key;
            string value;
            Random r = new Random();

            for (int i = 0; i < nel; i++)
            {
                Console.WriteLine("Enter key for " + i + " element:");
                key = Console.ReadLine();
                Console.WriteLine("Enter value for " + i + " element:");
                value = Console.ReadLine();
                Console.WriteLine();
                dc.Add(key, value);
            }

            Console.WriteLine("The dictionary is:");

            for (int i = 0; i < nel; i++)
            {
                Console.WriteLine(dc.ElementAt(i).Key + ": " + dc.ElementAt(i).Value);
            }

            Dictionary dc1 = new();
            dc1.SKeys(dc);

        }
    }
}
