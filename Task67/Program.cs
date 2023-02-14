// =====================Задача 67================================
// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// ==============================================================

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int SumNumbers(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumbers(num / 10);
}


Console.Write("Введите число: ");
int number = UserInput();
int sum = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа {sum}");