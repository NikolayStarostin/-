// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Math.Pow(2, 10);
// Math.Sqrt(5);
// double d = 5.099753443;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);

Console.WriteLine("Введите координаты точки A: ");
Console.Write("Ax: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Ay: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("Bx: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("By: ");
double by = Convert.ToDouble(Console.ReadLine());

double dist = Distance(ax, ay, bx, by);

Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}