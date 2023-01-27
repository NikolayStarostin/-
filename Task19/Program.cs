//=====================19.ЗАДАЧА====================
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли
// оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
//===================================================


Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

if (number < 10000 || number > 99999)
    Console.WriteLine("Некорректный ввод");
else
    if (number / 10000 % 10 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    Console.WriteLine("да");
    else
    Console.WriteLine("нет");
