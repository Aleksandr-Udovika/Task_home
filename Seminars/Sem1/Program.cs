// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"You input ->  {num}");


// Условие: **

// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умножает на само себяя).

// **Например:**

// 4 -> 16
// -3 -> 9
// -7 -> 49

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{num} -> {num * num}");

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// **последнюю** цифру этого числа.

// 456 -> 6

// 782 -> 2

// 918 -> 8

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"{num} -> {num % 10}");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не трёхзначное число");
// }


// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"{num} -> {num % 100 / 10}");
// } else if(num <= 100)
// {
//     System.Console.WriteLine($"{num} -> у этого числа нет третьей цифры");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не трёхзначное число");
// }




// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = -n;
// while(n >= current)
// {
//     System.Console.Write(current + " ");
//     current++;



// Напишите программу, которая
// на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// System.Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if(a == b*b)
// {
//     System.Console.WriteLine($"{a} {b} True");
// }
// else
// {
//     System.Console.WriteLine($"{a} {b} False");
// }


// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

// System.Console.WriteLine("Введите номер: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(n == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(n == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if(n == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(n == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(n == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(n == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Введите корректное число");
// }




System.Console.WriteLine("Введите номер: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n <= 6)
{
    Console.WriteLine("Не выходной");
}
else if(n == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Введите корректное число");
}


















