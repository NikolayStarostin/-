// =====================Задача 64================================
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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

void NaturalNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumber(num - 1);
}


Console.Write("Введите натуральное число: ");
int number = UserInput();
if (number < 0) IncorrectValue();
if (number % 1 !=0) IncorrectValue();
Console.Write($"N = {number} -> ");
NaturalNumber(number);

