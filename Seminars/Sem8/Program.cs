// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

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

// void ChangeRows(int[,] matrix, int row1, int row2)
// {
//     row1 -= 1;
//     row2 -= 1;
//     if (row1 > matrix.GetLength(0) || row2 > matrix.GetLength(0))
//     {
//         System.Console.WriteLine("Ivalid input");
//     }
//     else
//     {
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             int temp = matrix[row1, i];
//             matrix[row1, i] = matrix[row2, i];
//             matrix[row2, i] = temp;
//         }
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

// int[,] matrix = CreateRandomMatrix(rows, columns, minValue, maxValue);
// PrintMatrix(matrix);

// System.Console.Write("Input number of first row what you want to change: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number of second row what you want to change: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// ChangeRows(matrix, row1, row2);
// PrintMatrix(matrix);

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это возможно, программа должна вывести сообщение для пользователя.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7



int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
// Запятые в квадратных скобках - означают колличество мерности массива.
// rows - строчки, columns - столбцы, min и max - это от и до
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) // вложенный цикл
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // GetLenght - возвращает колличество строчек или столбцов нашего двухмерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void RowsToColumns(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        System.Console.WriteLine("Invalid input");
    }
    else
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
}

System.Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, columns, minValue, maxValue);
PrintMatrix(matrix);
RowsToColumns(matrix);
PrintMatrix(matrix);









