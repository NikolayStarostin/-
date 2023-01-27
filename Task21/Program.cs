//=====================21.ЗАДАЧА========================
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//=======================================================

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.WriteLine("Введите координаты точки A:");
Console.Write("Ax: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Ay: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Az: ");
double az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("Bx: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("By: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Bz: ");
double bz = Convert.ToDouble(Console.ReadLine());

double dist = Distance(ax, ay, az, bx, by, bz);
Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));
