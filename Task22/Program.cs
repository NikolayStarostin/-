// 22. Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
void SquareTable(int x)
{
    int count = 1;
    while (count <= x)
    {
        Console.WriteLine($"|{count,2} | {Math.Pow(count, 2),2}|");
        count++;
    }
}
SquareTable(x);