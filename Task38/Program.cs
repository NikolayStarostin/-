// =====================Задача 38================================
// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
// ==============================================================


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        //arr[i] = Convert.ToDouble(rnd.Next(min, max));
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double FindMaxDigit(double[] arr)
{
    {
        double max = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] > max)
                max = arr[j];
        }
        max = Math.Round(max, 1);
        return max;
    }
}

double FindMinDigit(double[] arr)
{
    {
        double min = arr[0];
        for (int k = 0; k < arr.Length; k++)
        {
            if (arr[k] < min)
                min = arr[k];
        }
        min = Math.Round(min, 1);
        return min;
    }
}

double Difference(double mindigit, double maxdigit)
{
    double diff = 0;
    {
        diff = maxdigit - mindigit;
        diff = Math.Round(diff, 1);
    }
    return diff;
}

Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = CreateArrayRndDouble(size, 1, 99);
PrintArrayDouble(arr);
double findmax = FindMaxDigit(arr);
double findmin = FindMinDigit(arr);
double difference = Difference(findmin, findmax);
Console.Write($" -> {difference}");