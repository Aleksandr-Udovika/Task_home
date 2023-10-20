

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100 && num <= 999)
{
    System.Console.WriteLine($"{num} -> {num % 10}");
}
else
{
    System.Console.WriteLine("Вы ввели не трёхзначное число");
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6 // больше 3х цифр не знаю как сделать, а копипастить то, что ещё не 
// понял не стал, оставил то что более-менее понял :D


System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num <= 999)
{
    System.Console.WriteLine($"{num} -> {num % 100 / 10}");
} else if(num <= 100)
{
    System.Console.WriteLine($"{num} -> у этого числа нет третьей цифры");
}
else
{
    System.Console.WriteLine("Вы ввели не трёхзначное число");
}


// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите номер: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n <= 5)
{
    Console.WriteLine("Не выходной");
}
else if(n == 6)
{
    Console.WriteLine("Выходной");
}
else if(n == 7)
{
    Console.WriteLine("Выходной"); 
}
else if(n >= 8) 
{
    Console.WriteLine("Введите корректное число");
}

