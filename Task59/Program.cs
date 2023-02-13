// =====================Задача 57================================
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
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
                Console.Write($"{array[i, j],4} |");
            else Console.WriteLine($"{array[i, j],4}  ]");
        }
    }
}

int[] MatrixMinElemIndex(int[,] array2D)
{
    int[] result = new int[2];
    int min = array2D[0, 0];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] < min)
            {
                min = array2D[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"[{array[i],4} |");
        else Console.WriteLine($"{array[i],4}  ]");
    }
}

int[,] DeleteMinRowsColumns(int[,] array2D, int[] array)
{
    int rowsCount = array2D.GetLength(0) - 1;
    int columnsCount = array2D.GetLength(1) - 1;
    int[,] resultMatrix = new int[rowsCount, columnsCount];
    int m = 0;
    for (int i = 0; i < rowsCount; i++)
    {
        if (m == array[0]) m++;
        int n = 0;
        for (int j = 0; j < columnsCount; j++)
        {
            if (n == array[1]) n++;
            resultMatrix[i, j] = array2D[m, n];
            n++;
        }
        m++;
    }
    return resultMatrix;
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

int[] indexArray = MatrixMinElemIndex(matrix);
Console.WriteLine("Индекс минимального элемента: ");
PrintArray(indexArray);

int[,] answerMatrix = DeleteMinRowsColumns(matrix, indexArray);
Console.WriteLine("Результирующий массив: ");
PrintMatrix(answerMatrix);