// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

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


// void ReverseArray(int[] array) 
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }    
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// ReverseArray(myArray);
// PrintArray(myArray);


// Напииште программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num /= 2;
//     }
//     return result;
// }


// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DecimalToBinary(num));



// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые числа Фибоначчи: 0 и 1.

// void convert10to2(int N); // здесь должен быть код, вставить из других более ранних уроков!
//                           // Тогда код заработает.

// void fibonacci(int N)
// {
//     int [] array = new int[N];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < N; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     printarray(array);
// }

// Console.WriteLine("Input N");
// int N = Convert.ToInt32(Console.ReadLine());
// // convert10to2(N);
// Console.WriteLine("First " + N + " digits of fibonacci");
// fibonacci(N);


// Нашите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.


bool triangleExist(int a, int b, int c){
    if (a < (b+c) && b < (a+c) && c < (a+b)) return true;
    else return false;
}
Console.WriteLine("Input a, b, c");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(triangleExist(a,b,c));


int[] reversearray(int[ array]) 

System.Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
ReverseArray(myArray);
PrintArray(myArray);


