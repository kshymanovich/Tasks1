using System;

namespace StringTask1
{
    class Symbol
    {
        public void CountS(string str) // 7. подсчитать кол-во вхождений символа "h" в строке
        {
            int hcounts = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'h') hcounts++;
            }
            Console.WriteLine("The number of symbol 'h' in your string: " + hcounts);
        }

        public void WordNum(string str) // 8.подсчитать кол - во слов в строке(словом считается группа символов, отделенная от другой такой же пробелом)
        {
            string[] words = str.Split(' ');
            int wordcounts = words.Length;

            Console.WriteLine("Number of words in your string is " + wordcounts);
        }

        public void LongestWord(string str)// 9. определить длину самого длинного слова в строке (словом считается группа символов, отделенная от другой такой же пробелом)
        {
            int longlength = 0;
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longlength) longlength = words[i].Length;
            }

            Console.WriteLine("The longest word in your string has " + longlength + " symbols");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string please:");
            string str = Console.ReadLine();
            Console.WriteLine();

            Symbol symb1 = new();
            symb1.CountS(str);

            Console.WriteLine();

            symb1.WordNum(str);

            Console.WriteLine();

            symb1.LongestWord(str);

        }

        
    }
}
