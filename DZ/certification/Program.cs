// Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// MoreToLess(number, count);
// void MoreToLess(int n, int count) {
//     if (count > n) {
//         Console.WriteLine($"Введите корректное число");
//         return;
//     }
//     else {
//         MoreToLess(n, count + 1);
//         Console.Write(count + " ");
//     }
// }



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = m; i <= n; i++) {
//     sum += i;
// }
// Console.WriteLine("Сумма чисел от {0} до {1} = {2}", m, n, sum);


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SumFromMToN(m, n);
// void SumFromMToN(int m, int n){
//     Console.Write(SumMN(m - 1, n));
// }
// int SumMN(int m, int n){
//     int res = m;
//     if (m == n)
//         return 0;
//     else{
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n){
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}
Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");



