// Задайте двумерный массив размером m x n, заполненый случайными числами.

// m = 3, n = 4/

// 1 4 8 19

// 5 -2 33 -2

// 77 3 8 1

// int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
// // Запятые в квадратных скобках - означают колличество мерности массива.
// // rows - строчки, columns - столбцы, min и max - это от и до
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++) // вложенный цикл
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght - возвращает колличество строчек или столбцов нашего двухмерного массива
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.Write("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input numbers of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myMatrix = CreateRandomMatrix(rows, columns, minValue, maxValue);
// PrintMatrix(myMatrix);



// Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали с индексами (0, 0); (1, 1) и т.д.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// // сумма элементов по диагонали: 1+9+2 = 12

// int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
// // Запятые в квадратных скобках - означают колличество мерности массива.
// // rows - строчки, columns - столбцы, min и max - это от и до
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++) // вложенный цикл
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght - возвращает колличество строчек или столбцов нашего двухмерного массива
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int MainDiagonalSum(int[,] matrix)
// {
//     int sum = 0;
//     // for (int i = 0; i < matrix.GetLength(0); i++) // GetLenght - возвращает колличество строчек или столбцов нашего двухмерного массива
//     // {
//     //     for (int j = 0; j < matrix.GetLength(1); j++)
//     //     {
//     //         if (i == j)
//     //         {
//     //         sum += matrix[i, j];
//     //         }
//     //     }
//     // return sum; // здесь тоже используется "return sum"
//     // }
//     if (matrix.GetLength(0) > matrix.GetLength(1))
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             sum += matrix[i, i];
//         }
//     else
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sum += matrix[i, i];
//         }
//     // return sum; // в верхнем коде закомиченном тоже используется "return sum"
// }

// System.Console.Write("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input numbers of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myMatrix = CreateRandomMatrix(rows, columns, minValue, maxValue);
// PrintMatrix(myMatrix);
// System.Console.WriteLine(MainDiagonalSum(myMatrix));


int[,] Random2darray(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength[0]; i++)
    {
        for (int j = 0; j < matrix.GetLength[1]; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void diagsum(int[,] matrix)
{
    int sum = 0;
    int min = matrix.GetLength[0];
    if (min > matrix.GetLength[1])
        min = matrix.GetLength(1);
    for (int i = 0; i < min; i++)
    {
        sum += matrix[i, i];
    }
    Console.Write(sum);
}

int[,] sumindmatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

System.Console.Write("Input rows");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input columns");
int col = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input min");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input max");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = sumindmatrix(row, col);
PrintMatrix(myMatrix);
// System.Console.WriteLine(MainDiagonalSum(myMatrix));
