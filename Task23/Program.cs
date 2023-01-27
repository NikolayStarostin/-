//=====================23.ЗАДАЧА========================
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//=======================================================

void CubeTable(int x)
{
    int count = 1;
    while (count <= x)
    {
        Console.WriteLine($"+----+------+");
        Console.WriteLine($"|{count, 3} | {Math.Pow(count, 3),-5}|");
        count++;
    }
    Console.WriteLine($"+----+------+");
}

Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());

CubeTable(x);
