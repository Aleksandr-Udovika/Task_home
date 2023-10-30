
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
//  натуральную степень B.

//  3, 5 -> 243 (3⁵);   
//  2, 4 -> 16   */

// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int stepen = a;

// for (int i = 1; i < b; i++)
// {
// stepen = stepen * a;
// }
// Console.WriteLine("A в степени B равно: " + stepen);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11; 
// 82 -> 10; 
// 9012 -> 12;

// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// 5 -> [1, 2, 5, 7, 19]; 
// 3 -> [6, 1, 33];

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


