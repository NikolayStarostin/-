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
    if (m < 0) IncorrectValue();
    if (n < 0) IncorrectValue();
    if (m > n) return m += SumNumbers(m - 1, n);
    if (m < n) return n += SumNumbers(m, n - 1);
    else return m;
}


Console.Write("Введите натуральное число M: ");
int numberM = UserInput();
Console.Write("Введите натуральное число N: ");
int numberN = UserInput();
int sumNumbers = SumNumbers(numberM, numberN);
if (numberM == numberN) Console.Write($"Сумма натуральных элементов {numberM}");
else Console.Write($"Сумма натуральных элементов {sumNumbers}");