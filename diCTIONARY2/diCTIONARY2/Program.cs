using System;
using System.Collections;
//дан словарь (ключ - строка, значение - строка). получить список ключей, для которых в значении есть символ "s"

namespace Dictionary2
{
    class Dictionary
    {
        public void SKeys(SortedList dc, int nel)
        {
            ArrayList keylist = new();
            int b = 0;
            string d;
            for (int i = 0; i < nel; i++)
            {
                d = dc.GetByIndex(i).ToString();
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[j] == 's')
                    {
                        keylist.Add((object)dc.GetKey(i));
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
            SortedList dc = new();

            Console.WriteLine("Enter a number of elements in dictionary:");

            int nel = int.Parse(Console.ReadLine()); //user defines the number of elements in the dictionary

            Console.WriteLine();
            
            string d;
            int k;
            Random r = new Random();

            for (int i = 0; i < nel; i++)
            {
                k = r.Next(-1000, 1000);
                Console.WriteLine("Enter a string value for key " + k + ":");
                d = Console.ReadLine();
                dc.Add(k, d);
            }

            Console.WriteLine();
            Console.WriteLine("The dictionary is:");

            for (int i = 0; i < nel; i++)
            {
                Console.WriteLine(dc.GetKey(i) + ": " + dc.GetByIndex(i));
            }

            Dictionary dc1 = new();
            dc1.SKeys(dc, nel);

        }
    }
}
