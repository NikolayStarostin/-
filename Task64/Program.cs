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

void NaturalNumber(int num, int min)
{
    if (num == 0) return;
    Console.Write($"{num}, ");
    if (num > min +1)
    NaturalNumber(num - 1, min);
}


Console.Write("Введите натуральное число: ");
int number = UserInput();
int minnumber = 1;
if (number < 0) IncorrectValue();
if (number % 1 !=0) IncorrectValue();
Console.Write($"N = {number} -> \"");
NaturalNumber(number, minnumber);
Console.Write($"{minnumber}\"");