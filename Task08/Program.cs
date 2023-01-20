// 8. Напишите программу, которая на вход
// принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 2;
while (number <= N)
{
    if (number % 2 == 0)
        Console.WriteLine(number + " ");
    number++;
}


// **ЧЕРНОВИК АЛЬТЕРНАТИВНЫЙ ВАРИАНТ**
// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 1)
// int number = 2;
// {
//         while (number <= N)
//     {
//         Console.WriteLine(number + " ");
//         number++;
//         if (number % 2 == 0) // в данном проверка нужна только для того,
//         {                   // чтобы в случае числовых значение 1, 2, 5, 7, 8, 9, 10
//             return;         // number += 2 не выводил ошибочно нечетные значение
//         }
//         else
//         {
//             number++;
//         }
//     }
// }
// else
//     {
//         Console.WriteLine("Введено некорректное значение, число должно быть больше 1");
//     }