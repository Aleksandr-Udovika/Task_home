// int FindQuarter(int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     else if(x < 0 && y > 0) return 2;
//     else if(x < 0 && y < 0) return 3;
//     else if(x > 0 && y < 0) return 4;
//     System.Console.WriteLine("The point lies on the line!");
//     return 0;   
// }

// System.Console.Write("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int result = FindQuarter(x, y);
// System.Console.WriteLine($"The point located at {result} quarter");




// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3, 6); B (2, 1); -> 5,09
// A (7;-5); B (1; -1); -> 7,21

double FindDistance(double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2); // библиотека(Math) и в ней имеются 
    // разные функции, к примеру Sqrt - корень. Math.Pow - возводит выражение в нужную нам степень.
    // Math.Round - округляет числа
}

System.Console.Write("Input XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FindDistance(xa, ya, xb, yb));
