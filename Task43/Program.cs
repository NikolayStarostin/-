// =====================Задача 43================================
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// ==============================================================

// Формула нахождения кординаты точки:
// x = (b2 - b1) / (k1 - k2)
// y = k1 * (b2 - b1) / (k1 - k2) + b1


double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double FindX(double b1, double b2, double k1, double k2)
{
    return Math.Round((b2 - b1) / (k1 - k2), 1);
}

double FindY(double b1, double b2, double k1, double k2)
{
    return Math.Round((k1 * (b2 - b1) / (k1 - k2) + b1), 1);
}

double b1 = ReadInt("Введите значение b1: ");
double k1 = ReadInt("Введите значение k1: ");
double b2 = ReadInt("Введите значение b2: ");
double k2 = ReadInt("Введите значение k2: ");
double x = FindX(b1, b2, k1, k2);
double y = FindY(b1, b2, k1, k2);
if (b1 == b2 ^ k1 == k2)
    Console.WriteLine("Прямые не пересекаются");
if (b1 == b2 && k1 == k2)
    Console.WriteLine("Прямые совпадают");
if (b1 != b2 && k1 != k2)
    Console.WriteLine($"({x}:{y})");
