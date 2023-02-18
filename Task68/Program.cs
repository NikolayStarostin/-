// =====================Задача 68================================
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// ==============================================================

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}

Console.Write("Введите натуральное число m: ");
int m = UserInput();
Console.Write("Введите натуральное число n: ");
int n = UserInput();
if (m >= 0 && n >= 0)
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");
else Console.WriteLine("Функция не рабочая");