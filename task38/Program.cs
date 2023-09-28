// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System;

namespace task38
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            double[] mass = new double[size];
            FullArray(mass);
            Array(mass);
        }

        static void FullArray(double[] array)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().NextDouble();
                Console.WriteLine("Mass [" + i + "]:" + array[i]);
            }
        }

        static void Array(double[] arr)
        {
            double max = arr[0];
            double min = arr[0];
            double result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= max){
                    max = arr[i];
                }
                else{
                    if(arr[i] <= min){
                        min = arr[i];
                    }
                }
                result = max - min;
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Разница: " + result);            
        }
    }
}
