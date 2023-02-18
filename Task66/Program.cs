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

int SumNumbers(int start, int end)
{
    return start == end ? end : start + SumNumbers(start + 1, end);
}


Console.Write("Введите натуральное число M: ");
int numberM = UserInput();
if (numberM < 0) IncorrectValue();

Console.Write("Введите натуральное число N: ");
int numberN = UserInput();
if (numberN < 0) IncorrectValue();

int sum = 0;

if (numberM > numberN)
    sum = SumNumbers(numberN, numberM);
else
    sum = SumNumbers(numberM, numberN);

Console.Write($"Сумма натуральных элементов {sum}");