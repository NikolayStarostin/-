// =====================Задача 36=================================
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// ==============================================================


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumOfOddNumbers(int[] arr)
{
    int sum = 0;
    int j = 0;
    while (j <= arr.Length)
    {
        sum = sum + arr[j];
        {
            j = j + 2;
        }
    }
    return sum;
}

Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(size, -1000, 1000);
int sumnumbers = SumOfOddNumbers(arr);
PrintArray(arr);
Console.Write ($" -> {sumnumbers}");