// =====================Задача 69================================
// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
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

int FactorialNum(int numA, int numB)
{
    if (numB == 0) return 1;
    else return numA * FactorialNum(numA, numB - 1);
}


Console.Write("Введите число A: ");
int numberA = UserInput();
Console.Write("Введите число B: ");
int numberB = UserInput();
int factorial = FactorialNum(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} -> {factorial}");