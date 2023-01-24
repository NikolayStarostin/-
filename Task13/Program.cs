//==========================13. ЗАДАЧА=============================
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. Выполнить с помощью
// числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//=================================================================
int ResultThirdDigit(int number)
{
    int count = 0;
        while (number > 999)
            number = number / 10;
        count++;
    return number % 10;
}


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldnumber = number;

number = Math.Abs(number);

int res = ResultThirdDigit(number);

if (number > -100 && number < 100)
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine($"Третья цифра числа {oldnumber} -> {res}");
