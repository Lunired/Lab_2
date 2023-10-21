using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class Program
    {

        static void Task14()
        {
            /*Дан массив. Составить программу:
             извлечения квадратного корня из любого элемента массива;
           */
            Random random = new Random();
            int number;
            Console.WriteLine("Задание 14");
            Console.Write("Введите значение массива :");
            //Проверка масства на правильный ввод числа размерности массива.
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 1)
                    {
                        Console.Write("Минимальное значение массива = 1" + "\n" + "Введите значение массива :");

                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Число должно быть натуральным");
                }
            }

            double[] array = new double[number];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * (20 - 4) + 3;
                Console.Write(array[i] + "   ");
            }
            //извлечения квадратного корня из любого элемента массива;
            //расчета среднего арифметического двух любых элементов массива.
            int number_selection, average1, average2;
            Console.WriteLine("\n" + "Введите числа для вычисления квадратного корня и среднего арифмитического");
            while (true)
            {
                try
                {
                    Console.Write("квадратный корень");
                    number_selection = int.Parse(Console.ReadLine());
                    Console.Write("первый элемент");
                    average1 = int.Parse(Console.ReadLine());
                    Console.Write("второй элемент");
                    average2 = int.Parse(Console.ReadLine());
                    if (number_selection < 0 || average1 < 0 || average2 < 0)
                    {
                        Console.WriteLine("Минимальное значение 0");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Число должно быть натуральным");
                }
            }
            for (int i = 0; i < array.Length; i++)
            {

                if (i == number_selection)
                {
                    double result = Math.Sqrt(array[i]);
                    Console.WriteLine($" Ответ:  {result}");
                }
            }

            if (average1 < array.Length && average2 < array.Length)
            {
                double sum = 0;
                double count = 0;

                for (int i = average1; i <= average2; i++)
                {
                    sum += array[i];
                    count++;
                }
                double result = sum / count;
                Console.WriteLine($" Ответ:  {result}");
            }
        }
        static void Task51()
        {
            /*Заполнить массив из N элементов с начальным значением заданным А[0] ≠ 0, по принципу A[i] = A[i div 2] + A[i–1].*/
            int N;
            //Проверка масства на правильный ввод числа размерности массива.
            while (true)
            {
                try
                {
                    N = int.Parse(Console.ReadLine());
                    if (N < 1)
                    {
                        Console.Write("Минимальное значение массива = 1" + "\n" + "Введите значение массива :");

                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Число должно быть натуральным");
                }
            }

            double[] array = new double[N];
            double my_number = 0;
            while (true)
            {
                my_number = double.Parse(Console.ReadLine());
                if (my_number == 0)
                {
                    Console.WriteLine("Число не может равняться 0");
                }
                else
                {
                    break;
                }
            }
            array[0] = my_number;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 1; i < N; i++)
            {
                array[i] = array[i / 2] + array[i - 1];
            }

            // Вывод массива на экран
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"A[{i}] = {array[i]}");
            }
        }
        static void Task112()
        {
            //В одномерный массив целых чисел на место минимального элемента вставить максимальный элемент.
            Random random = new Random();

            int number, imax = 0, imin = 0;
            Console.Write("Введите значение массива :");
            //Проверка масства на правильный ввод числа размерности массива.
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 1)
                    {
                        Console.Write("Минимальное значение массива = 1" + "\n" + "Введите значение массива :");

                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Число должно быть натуральным");
                }
            }
            int[] array = new int[number];
            //Замета mix елемента на max
            Console.Write("Исходный масив:");
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write((array[i] = random.Next(0, 89)) + " ");
                if (array[imin] > array[i])
                {

                    imin = i;
                }
                if (array[imax] < array[i])
                {

                    imax = i;
                }
            }
            Console.WriteLine();
            //  Console.WriteLine("vaumax" + imax);
            //  Console.WriteLine("vaumin" + imin);
            // int x = array[imin];
            array[imin] = array[imax];
            // array[imax] = x;
            Console.Write("изменненый массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Task198()
        {

            /*
    Известно, что в массиве имеются элементы, равные 5. Определить:
    а) номер первого из них;
    б) номер последнего из них.
    В обеих задачах условную инструкцию не использовать.
    */

            int five = 5, number = 0;
            Random random = new Random();
            Console.WriteLine("Введите кол-во елементов массивва:");
            //Проверка масства на правильный ввод числа размерности массива.
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 1)
                    {
                        Console.WriteLine("Минимальное значение массива = 1" + "\n" + "Введите значение массива :");

                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Число должно быть натуральным");
                }
            }
            //Вводимв массив и n-е кол-во пятерокв нем.
            int[] array = new int[number];

            for (int i = 0; i < array.Length; i++)
            {
                if (random.Next(3) == 0)
                {
                    array[i] = five;
                }
                else
                {
                    array[i] = random.Next(0, 89);
                }
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Находим индекс первого и последнего элементов 
            int firstelement = -1, finallelement = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == five)
                {
                    if (firstelement == -1)
                    {
                        firstelement = i;
                    }
                    finallelement = i;
                }
            }

            bool found = false;
            foreach (int element in array)
            {
                if (five == element)
                {
                    found = true;
                    break;

                }
            }
            if (found)
            {
                Console.WriteLine("Первая 5 под индексом: " + firstelement + "\t" + "Последняя 5 под индексом: " + finallelement);
            }
            else
            {
                Console.Write("Нет 5 в массиве");
            }
        }
        static void Task205()
        {
            /*Дан массив целых чисел.
а) Напечатать все элементы, предшествующие первому элементу с заданным значением n. 
   Если элементов, равных n, в массиве нет, то должны быть напечатаны все элементы.

б) Напечатать все элементы, следующие за последним элементом, оканчивающимся цифрой 7. 
   Если элементов, оканчивающихся цифрой 7, в массиве нет, то ни один элемент не должен быть напечатан.
*/
            int number = 0, n;
            Random random = new Random();
            Console.WriteLine("Введите значение для n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во елементов массивва:");
            //Проверка масства на правильный ввод числа размерности массива.
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 1)
                    {
                        Console.WriteLine("Минимальное значение массива = 1" + "\n" + "Введите значение массива :");

                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Число должно быть натуральным");
                }
            }
            int[] array = new int[number];
            Console.Write("Массив:" + "\t");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 4);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            //Нахождение елемента заданное пользователем, и выводит все элементы массива до этого элемента, либо весь массив, если n не найден.
            //bool found = false;
            int found = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    found = i;
                    Console.WriteLine("Все элементы до первого значения: " + n);
                    break;
                }
            }
            if (found != -1)
            {
                for (int i = found - 1; i > -1; i--)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                Console.WriteLine($"Элемент {n} отсутствует, поэтому выводим весь массив: ");
                foreach (int element in array)
                {
                    Console.Write($"{element} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Конец первой части");
            /*Напечатать все элементы, следующие за последним элементом, оканчивающимся цифрой 7.
   Если элементов, оканчивающихся цифрой 7, в массиве нет, то ни один элемент не должен быть напечатан.*/
            int[] array2 = new int[number];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, 900);
                Console.Write(array2[i] + " ");
            }

            int indexSeven = -1, seven = 7;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] % 10 == seven)
                {
                    indexSeven = i;
                    break;
                }
            }
            if (indexSeven != -1)
            {
                Console.WriteLine("Вывод всех последующих елементов после елемента " + indexSeven);
                for (int i = indexSeven + 1; i < array2.Length; i++)
                {
                    Console.Write($"{array2[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Нет элементов");
            }


        }
        static void Main(string[] args)
        {
            //Task14();
            // Task51();
            //  Task112();
            //Task198();
            Task205();
        }
    }
}






