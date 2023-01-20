// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. 
// Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число a: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
int remains = firstDigit % secondDigit;
if (firstDigit / secondDigit == 0)
    Console.WriteLine($"Кратно");
else
    Console.WriteLine($"Некратно, {remains}");