// Задайте массив из 12 элементов,  заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.


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

// void FindPosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0) sumNeg += array[i];
//         else sumPos += array[i];
//     }
//     System.Console.WriteLine($"Sum of positive elements in array -> {sumPos}," +
//     $"sum of negative elements -> {sumNeg}");
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// FindPosNegSum(myArray);


// Задайте одномерный массивиз 123 случайных чисел. 
// Найдите колличество элементов массива, значения которых лежат в отрезке [10, 99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

// int ElementInBordersCounter(int[] array, int max, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[] >= min && array[i] <= max) count++;
//     }
//     return ElementInBordersCounter;
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the value of the minimum boundary within which you would like to find elements ");
// int min = Convert.ToInt32(Console.ReadLIne());
// System.Console.WriteLine("Enter the value of the minimum boundary within which you would like to find elements ");
// int max = Convert.ToInt32(Console.ReadLine());



// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine($"There are {ElementInBordersCounter()}" elements in this array that are that are within this boundary[{min}, {max}]");



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

// void ChangeNumber(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the value of the min...");

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// ChangeNumber(myArray);
// PrintArray(myArray);

// Задайте массив. напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

// int[] CreateRandomArray(int size, int minValue, int maxValue )
// {
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++) 
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

// bool HasNumber(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(HasNumber(myArray, number));



