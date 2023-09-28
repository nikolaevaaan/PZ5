// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

namespace task36
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[] mass = new int[size];
            FullArray(mass);
            Array(mass);
        }

        static void FullArray(int[] array)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
                Console.WriteLine("Mass [" + i + "]:" + array[i]);
            }
        }

        static void Array(int[] arr)
        {
            int sum = 0;
            int even_number = 0;
            int odd_number = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }                
            }

            Console.WriteLine("Сумма: " + sum);            
        }
    }
}
