// 11. Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int res = RemoveSecondDigit(number);

Console.WriteLine($"{number} -> {res}");

int RemoveSecondDigit(int num)
{
    int num1 = number / 100;
    int num3 = number % 10;
    int result = num1 * 10 + num3;
    return result;
}