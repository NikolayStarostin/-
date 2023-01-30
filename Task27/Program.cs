// ======================Задача 27================================
// Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
//===============================================================

int NumberLen(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

void SumOfNumbers(int n, int len)
{
    int sum = 0;
    int startNumber = n;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Cумма цифр числа {startNumber} -> {sum}");
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int len = NumberLen(number);
SumOfNumbers(number, len);