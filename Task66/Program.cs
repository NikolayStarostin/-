// =====================Задача 66================================
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
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

int SumNumbers(int m, int n)
{
    if (m == n) return n;
    n += SumNumbers (m, n-1);
    return n;
}


Console.Write("Введите натуральное число M: ");
int numberM = UserInput();
Console.Write("Введите натуральное число N: ");
int numberN = UserInput();
if (numberM < 0 && numberN < 0) IncorrectValue();
if (numberM % 1 != 0 && numberN % 1 != 0) IncorrectValue();
int sumNumbers = SumNumbers(numberM, numberN);
Console.Write($"Сумма чисел от {numberM} до {numberN} = {sumNumbers}");