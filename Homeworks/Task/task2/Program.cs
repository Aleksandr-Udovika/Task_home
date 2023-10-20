

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
else if(n >= 8) // написать бы в 5й строке
{
    Console.WriteLine("Введите корректное число");
}


