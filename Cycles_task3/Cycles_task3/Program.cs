using System;

namespace Cycles_task3
//Дано натуральное число. Подсчитать кол-во вхождений его максимальной цифры
{
    class Maxima {
        int numb;
        int max = 0;
        int cmax = 0;
        public Maxima (int n)
        {
            numb = n;
        }

        public int ShowNumber() {
            return numb;
        }

        public int GetMax() {
            int rest = numb;
            do {
                if (max < (rest % 10)) {
                    max = rest % 10;
                }
                rest /= 10;
            }
            while (rest > 0);
            return max;
        }

        public int CountMax() {
            int rest = numb;
            do {
                if (rest % 10 == max) {
                    cmax++;
                }
                rest /= 10;
            }
            while (rest > 0);
            return cmax;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Maxima m1 = new(1928991637);
            int max1 = m1.GetMax();
            int cm1 = m1.CountMax();
            Console.WriteLine("Number if occurence of digit {0} in number {1} is {2}", max1, m1.ShowNumber(), cm1);
            Console.ReadKey();
        }
    }
}
