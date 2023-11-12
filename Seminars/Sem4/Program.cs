// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// [1, 0, 1, 1, 0, 1, 0, 0]

// int[] CreateRandomArray(int size, int minValue, int maxValue )
// {
//     int[] array = new int[size]; // new - выделение памяти в нашем пк, для хранения массива
//     for (int i = 0; i < size; i++) // работая с массивами, почти всегда цикл "for"
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, minValue, maxValue));


// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(factorial(5));
    }

    // Task - 1
    static void sumByA(int a)
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum of A: {sum}");
    }

    // Task - 2 может с 2 начать

    static int factorial(int num)
    {
        int result = 1;
        for (int j = 1; j <= num; j++)
        {
            result *= j;
        }
        return result;
    }
}
