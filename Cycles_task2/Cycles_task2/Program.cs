using System;

namespace Cycles_task2
//Дано натуральное число. Найти минимальную его цифру
{
    class Number
    {

        int numb;
        int min = 9;

        public void getValue(int n) {
            numb = n;
        }

        public void getMin() {
            int rest = numb;
            do {
                if (min > (rest % 10)) {
                    min = rest % 10;
                }
                rest = rest / 10;
            }
            while (rest/10 > 0);
            Console.WriteLine("Minimal digit of {0} is {1}", numb, min);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.getValue(928374651);
            num1.getMin();
            Console.ReadKey();
        }
    }
}
