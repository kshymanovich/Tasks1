using System;
using System.Collections;
// Task 1. дан список целых чисел. Подсчитать количество отрицательных элементов
// Task 2. дан список целых чисел. Получить новый список, состоящий из элементов старого списка, циклически сдвинутых вправо на одну позицию. Пример: { 1, 2, 3}, { 3, 1, 2}
// Task 3. дан список целых чисел. Найти индекс и значение минимального элемента
// Task 4. дан список целых чисел. Найти два максимальных значения и получить новый список без них. Пример: { 9, 1, 2, 6}, { 1, 2}. 
namespace Collections_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //creating the array of random element of user defined size
            ArrayList cn = new();
            
            Console.WriteLine("Enter a number of elements in array:");
            
            int nel = int.Parse(Console.ReadLine()); //user defines the number of elements in the array

            Console.WriteLine();
            Console.WriteLine("The Array is:");

            Random r = new Random(); //elements in the array are randomly generated within (-1000; 1000) range
            
            for (int i = 0; i < nel; i++)
            {
                cn.Add(r.Next(-1000, 1000));
            }

            foreach(int i in cn)
            {
                Console.Write(i + " ");
            }

            int neg = 0;

            Console.WriteLine();

            //1. calculating the number of negative elements in the array
            foreach (int i in cn)
                {
                    if (i < 0)
                    {
                        neg++;
                    }
                }

            Console.WriteLine();
            Console.WriteLine("Task 1. The number of negative values in array is {0}", neg);

            //2. moving the elements one position forward
            int last = 0;
            foreach(int i in cn)
                {
                    last = (int)i;
                }

            object lasto = (object)last; 
            cn.RemoveAt(nel - 1);
            cn.Insert(0, lasto);

            Console.WriteLine();
            Console.WriteLine("Task 2. New Array:");
            foreach (int i in cn)
            {
                Console.Write(i + " ");
            }

            //3. index and value of min element

            int minvalue = 1000;
            
            
            foreach (int i in cn)
            {
                if (minvalue > (int)i)
                {
                    minvalue = (int)i;
                }
            }

            int minindex = (int)cn.IndexOf((object)minvalue);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Task 3. Position of minimum value {0} in the array is {1}", minvalue, minindex);

            //Removing two max values from the array

            int maxvalue1 = -1000;
            int maxvalue2 = -1000;


            foreach (int i in cn)
            {
                if (maxvalue1 <= (int)i)
                {
                    maxvalue2 = maxvalue1;
                    maxvalue1 = (int)i;
                }
                else if (maxvalue2 <= (int)i)
                {
                    maxvalue2 = (int)i;
                }
            }

            cn.Remove((object)maxvalue1);
            cn.Remove((object)maxvalue2);

            Console.WriteLine();

            Console.WriteLine("Task 4. New Array (with two maximum values ({0}, {1}) having been removed):", maxvalue1, maxvalue2);
            foreach (int i in cn)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();

        }
    }
}
