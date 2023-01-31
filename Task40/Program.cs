// =====================Задача 40================================
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
// ==============================================================

bool CheckSide(int a, int b, int c)
{
   return a < (b + c) && b < (a + c) && c < (a + b);
}

Console.WriteLine("Введите число:");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int side3 = Convert.ToInt32(Console.ReadLine());

bool check = CheckSide(side1, side2, side3);
Console.WriteLine(check ? "Да" : "Нет");
