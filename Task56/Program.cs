// =====================Задача 54================================
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// ==============================================================

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int[,] MatrixCreate(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1)
                Console.Write($"{array[i, j],4}  |");
            else Console.WriteLine($"{array[i, j],4}  ]");
        }
    }
}

int SumElementsInRow(int[,] array2D)
{
    int[] sumArray = new int[array2D.GetLength(0)];

    Console.Write("Сумма элементов в каждой строке: ");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sumArray[i] += array2D[i, j];
        }
        Console.Write($"{sumArray[i]} ");
    }
    int minSumRow = sumArray[0];
    int minRow = 1;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (sumArray[i] < minSumRow)
        {
            minSumRow = sumArray[i];
            minRow = i + 1;
        }
    }
    return minRow;
}


Console.Write("Введите количество строк в массиве: ");
int rowSize = UserInput();
if (rowSize <= 0) IncorrectValue();
Console.Write("Введите количество столбцов в массиве: ");
int columnsSize = UserInput();
if (columnsSize <= 0) IncorrectValue();
Console.Write("Введите минимальное значение: ");
int minValue = UserInput();
Console.Write("Введите максимальное значение: ");
int maxValue = UserInput();

int[,] matrix = MatrixCreate(rowSize, columnsSize, minValue, maxValue);
Console.WriteLine("Заданный массив: ");
PrintMatrix(matrix);

int minimalLine = SumElementsInRow(matrix);
Console.WriteLine();
Console.Write($"Строка с наименьшей суммой элементов: {minimalLine}.");