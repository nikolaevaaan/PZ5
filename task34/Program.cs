// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

namespace task34
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
                array[i] = new Random().Next(100, 999);
                Console.WriteLine("Mass [" + i + "]:" + array[i]);
            }
        }

        static void Array(int[] arr)
        {
            int even_number = 0;
            int odd_number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even_number +=1;
                }
                else
                {
                    odd_number += 1;
                }
            }

            Console.WriteLine("Количество четных чисел: " + even_number);
            Console.WriteLine("Количество нечетных чисел: " + odd_number);
        }
    }
}
