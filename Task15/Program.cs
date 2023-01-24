//=====================15. ЗАДАЧА========================
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
//=======================================================


Console.WriteLine("Введите число, обозначающее день недели, для проверки является ли этот день выходным:");
string dayNumber = Convert.ToString(Console.ReadLine());

switch (dayNumber)
{
    case "1":
        Console.WriteLine("Понедельник, нет");
        break;
    case "2":
        Console.WriteLine("Вторник, нет");
        break;
    case "3":
        Console.WriteLine("Среда, нет");
        break;
    case "4":
         Console.WriteLine("Четверг, нет");
        break;
    case "5":
        Console.WriteLine("Пятница, нет");
        break;
    case "6":
        Console.WriteLine("Суббота, да");
        break;
    case "7":
        Console.WriteLine("Воскресенье, да");
        break;
    default:
        Console.WriteLine("Введено некорректное значение");
         break;
}


//=======================АЛЬТЕРНАТИВНЫЙ ВАРИАНТ================
// Console.WriteLine("Введите число, обозначающее день недели, для проверки является ли этот день выходным:");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// if (dayNumber < 6 && dayNumber > 1)
// {
//     Console.WriteLine("нет");
// }
// if (dayNumber < 8 && dayNumber > 5)
// {
//     Console.WriteLine("да");
// }
// if (dayNumber < 1)
// {
//     Console.WriteLine("Введено некорректное значение");
// }
// if (dayNumber > 7)
// {
//     Console.WriteLine("Введено некорректное значение");
// }
