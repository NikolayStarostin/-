// ======================Задача 24================================
//  Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//===============================================================

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{a} в степени {b} -> {result}");
}

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < 0)
{
    Console.WriteLine("Введите натуральное число");
}
else
    if (number2 % 1 == 0)
    {
        Degree (number1, number2);
    }
    else Console.WriteLine("Введите целое число");
