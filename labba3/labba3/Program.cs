using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labba3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSortOf3elements();
            TestSortof100IndeticalElements();
            TestSortOfNullMassive();
            TestSortof1000ElemntsAndPairs();
            TestSortArrayOf1500000000Elements();
            Console.ReadKey();
        }
        static void QuickSort(int[] array)
        {
            if (array.Length == 0)//проверка на нулевой размер массива
            {
                int[] nullarray = new int[0];
            }
            else
                HoareSort(array, 0, array.Length - 1);
        }
        private static void TestSortArrayOf1500000000Elements()
        {
            //Проверка массива из 150000000 элементов
            int[] array1 = new int[150000000];
            int[] array2 = new int[150000000];
            var random = new Random();
            for (int i = 0; i < 150000000; i++)
            {
                array1[i] = random.Next(1, 15000000);
                array2[i] = random.Next(1, 15000000);
            }
            QuickSort(array1);
            if (array1.SequenceEqual(array2)!=true)
            {
                Console.WriteLine("Сортировка  массива работает неверно!");
            }
            else
            {
                Console.WriteLine("Сортировка  массива работает верно");
            }

        }
        private static void TestSortOf3elements() 
        {
            //Проверка сортировки для 3 элементов
            int[] array1 = new[] {5, 4, 3 };
            int[] array2 = new[] { 3, 4, 5 };
            QuickSort(array1);
            if (array1.SequenceEqual(array2)!=true)
            {
                Console.WriteLine("Сортировка  массива работает неверно!");

            }
            else
            {
                Console.WriteLine("Сортировка  массива работает верно");
            }

        }
        private static void TestSortof100IndeticalElements()
        {
            // Проверка сортировки для 100 одинаковых элементов
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            for (int i=0; i<100; i++)
            {
                array1[i] = 9;
                array2[i] = 9;
            }
            QuickSort(array1);
            if (array1.SequenceEqual(array2)!=true)
            {
                Console.WriteLine("Сортировка массива работает неверно!");
            
            }
            else
            {
                Console.WriteLine("Сортировка  массива работает верно");
            }
        }
        private static void TestSortOfNullMassive()
        {
            //Проверка сортировки для нулевого массива
            int[] array1 = new int[0];
            int[] array2 = new int[0];
            QuickSort(array1);
            if (array1.SequenceEqual(array2) != true)
            {
                Console.WriteLine("Сортировка массива работает неверно!");

            }
            else
            {
                Console.WriteLine("Сортировка массива работает верно");
            }
        }
        private static void TestSortof1000ElemntsAndPairs()
        {
            //Проверка сортировки для массива из 1000 случайных и упорядочивание пар
            int[] array = new int[1000];
            Random random = new Random();
            for (int i=0; i<1000; i++)
            {
                array[i] = random.Next(1, 1000);
            }
            QuickSort(array);
            for (int i=0; i<10; i++)
            {
                var k = random.Next(1, 1000);
                if (array[k] >= array[k+1])
                {
                    Console.WriteLine("Сортировка массива работает неверно!");

                }
                else
                {
                    Console.WriteLine("Сортировка массива работает верно");
                }
            }

        }

        static void HoareSort(int[] array, int start, int end)
        {
            if (end == start) return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
        }
    }
}
