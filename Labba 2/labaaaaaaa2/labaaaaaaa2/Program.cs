using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication

{

    class Program

    {

        public static int BinarySearch(int[] array, int value)  //naxoshdenie indeksa v massive

        {
            if (array == null) // esli pustoi massiv
            {
                return -1;
            }
            var left = 0;
            var right = array.Length - 1;
            while (left <= right)
            {
                var middle = (right + left) / 2;
                if (value < array[middle])
                {
                    right = middle - 1;
                    continue;

                }
                if (value > array[middle])
                {
                    left = middle + 1;
                    continue;
                }
                return middle;
            }

            return -1;
        }



        static void Main(string[] args)

        {

            TestNegativeNumbers();
            TestOneElement();
            TestNonExistentElement();
            TestOneElemenInNullMassiv();
            TestOneElementSomeTimes();
            TestOneElementIn100001BigMassiv();



            Console.ReadKey();

        }



        private static void TestNegativeNumbers()

        {

            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -3) !=2)

                Console.WriteLine("Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");

        }

        private static void TestNonExistentElement()

        {

            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");

        }

        private static void TestOneElement()

        {

            // Тестирование поиска одного элемента

            int[] onelement = new[] { 1, 2, 3, 4, 5 };

            if (BinarySearch(onelement, 3) != 2)

                Console.WriteLine("Поиск не нашёл число 3 среди чисел massiva");

            else

                Console.WriteLine("Поиск одного элемента работает корректно");

        }

        private static void TestOneElementSomeTimes()

        {

            // Тестирование повтора одного элемента
            int[] twice = new[] { 3, 3, 5, 6, 7 };

            if (twice [BinarySearch(twice, 3)] != 3)

                Console.WriteLine("Поиск не нашёл число 3 среди чисел massiva, kotoroe povtoryaetsya");

            else

                Console.WriteLine("Поиск povtoryaeshegosya элемента работает корректно");

        }
        private static void TestOneElemenInNullMassiv()

        {
            //Поиск в пустом массиве
            int[] nullmassiv =  { };
            if (BinarySearch(nullmassiv, 3) != -1)

                Console.WriteLine("Поиск v pustom massive работает некорректно ");

            else

                Console.WriteLine("Поиск v pustom massive работает корректно");

        }
        private static void TestOneElementIn100001BigMassiv()

        {
            

            //Поиск в массиве из 100001 элементов
            int[] bigmassiv = new int[100001];
            Random random = new Random();
            for (int i = 0; i < 100001; i++)
            {
                bigmassiv[i] = random.Next(1, 100002);
            }
            int index = random.Next(1, 100002);
            Array.Sort(bigmassiv);

            int number = bigmassiv[index];
            if (bigmassiv[BinarySearch(bigmassiv, number)] != number)
            {
                Console.WriteLine("Поиск работает некорректно");
            }
            else
            {
                Console.WriteLine("Поиск числа {0} со случайным индексом {1}  работает корректно", number, index);
            }
        }

    }
}