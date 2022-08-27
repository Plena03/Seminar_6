// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// x = (b2 - b1) / (k1 - k2);

Console.WriteLine();
Console.WriteLine("Программа находит точку пересечения двух прямых");
Console.WriteLine();

Console.WriteLine("Вводим координаты первой прямой:");
Console.WriteLine("Введите b1:");
string? numberStringb1 = Console.ReadLine();
double b1 = double.Parse(numberStringb1!);

Console.WriteLine("Введите k1:");
string? numberStringk1 = Console.ReadLine();
double k1 = double.Parse(numberStringk1!);
Console.WriteLine();

Console.WriteLine("Вводим координаты второй прямой:");
Console.WriteLine("Введите b2:");
string? numberStringb2 = Console.ReadLine();
double b2 = double.Parse(numberStringb2!);

Console.WriteLine("Введите k2:");
string? numberStringk2 = Console.ReadLine();
double k2 = double.Parse(numberStringk2!);

var x = (b2 - b1) / (k1 - k2);

    var y = k1 * x + b1;
    y = k2 * x + b2;

Console.WriteLine();
Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
Console.WriteLine();

if (k1 == k2)
{
   Console.WriteLine("Точек пересечения не существует"); 
}

