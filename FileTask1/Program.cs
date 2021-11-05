using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FileTask1
{
    class Dict
    {
        public ArrayList ReadFile(string filename)
        {
            // Reading a file into ArrayList
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int b = 0;
                ArrayList str = new ArrayList();
                Console.WriteLine("The initial file is:");
                while ((s = sr.ReadLine()) != null)
                {
                    str.Add((object)s);
                    Console.WriteLine(str[b]);
                    b++;
                }
                return str;
            }
        }

        public IList<IDictionary<string, string>> BuildList(ArrayList str)
        {
            // Getting Keys for a Dictionary
            string row = (string)str[0];
            string[] strsplit = row.Split(';');

            string key1 = strsplit[0];
            string key2 = strsplit[1];

            // Building a List of Dictionaries
            IList dict = new List<IDictionary<string, string>>();
            string val1;
            string val2;
            for (int i = 1; i < str.Count; i++)
            {
                IDictionary<string, string> dc = new Dictionary<string, string>();
                row = (string)str[i];
                strsplit = row.Split(';');
                val1 = strsplit[0];
                val2 = strsplit[1];
                dc.Add(key1, val1);
                dc.Add(key2, val2);
                dict.Add(dc);
            }
            return (IList<IDictionary<string, string>>)dict;
        }

        public void PrintDict(IList<IDictionary<string, string>> dict)
        {
            //Printing the List of Dictionaries down
            Console.WriteLine();
            Console.WriteLine("The List of Dictionaries is:");
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine(dict[i].ElementAt(0).Key + " = " + dict[i].ElementAt(0).Value + "," + dict[i].ElementAt(1).Key + " = " + dict[i].ElementAt(1).Value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Dict dict1 = new();
            string filename = "dict.csv";
            dict1.PrintDict(dict1.BuildList(dict1.ReadFile(filename)));

        }
    }
}
