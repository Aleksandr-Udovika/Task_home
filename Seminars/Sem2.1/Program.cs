// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46   4 6

// 782 -> 72   7 2

// 918 -> 98   9 8

// int DeleteSecondDigit(int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     int result = sot * 10 + ed;
//     return result;
// }

// System.Console.WriteLine("Input number:" );
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DeleteSecondDigit(num));


// int DeleteSecondDigit(int num)
// {
//     int ed = num % 10;  // выделяем третье число из трёх
//     int sot = num / 100;  // выделяем первое число из трёх
//     int result = sot * 10 + ed;
//     return result; // возвращает полученный результат и позже он выводится
// }


// int num = new Random().Next(100, 999 + 1); // рандомное число
// System.Console.WriteLine(num); // вывод рандомного числа
// System.Console.WriteLine(DeleteSecondDigit(num));


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// void CheckSquare(int a, int b)
// {
//     if(a == b * b)
//     {
//         System.Console.WriteLine($"{a} квадрат {b}");
//     } else if(b == a * a)
//     {
//         System.Console.WriteLine($"{b} квадрат {a}");
//     } else if(a == b)
//     {
//         System.Console.WriteLine($"{b} равно {a}");
//     }
//     else
//     {
//         System.Console.WriteLine($"не является");
//     }
// }

//         System.Console.Write("Input first number: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Input second number: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());
//         CheckSquare(num1, num2);


// bool Multiple(int a)
// {
//     if (a % 7 == 0 && a % 23 == 0)
//     return true;
//     else return false;
// }
// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = Multiple(num);
// System.Console.WriteLine(result);

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первомуу, 
// то программа выводит остаток от деления.

void CheckMultiple(int a, int b)
{
    if (a % b == 0)
    {
        System.Console.WriteLine($"{a} -> кратно {b}");
    } else
    {
        System.Console.WriteLine($"{a} -> некратно {b} остаток {a % b} ");
    }
}
System.Console.WriteLine("Input a");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input b");
int num2 = Convert.ToInt32(Console.ReadLine());
CheckMultiple(num1, num2);

