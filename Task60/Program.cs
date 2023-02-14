// =====================Задача 60================================
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.

// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
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

int[] CreateTwoDigitNonRepeatingArray(int size)
{
    int[] array = new int[size];
    int count = 10;
    for (int i = 0; i < size; i++)
    {
        array[i] = count++;
    }
    return array;
}

int[] CreateRndArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rnd = new Random().Next(0, array.GetLength(0)-1);
        int temp = array[rnd];
        array[rnd] = array[i];
        array[i] = temp;
    }
    return array;
}

int[,,] Create3DArray(int rows, int columns, int depths, int[] rndArray)
{
    int rndNumbers = 0;
    int[,,] array = new int[rows, columns, depths];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                array[i, j, k] = rndArray[rndNumbers];
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк: ");
int rows = UserInput();
if (rows <= 0) IncorrectValue();
Console.Write("Введите количество столбцов: ");
int columns = UserInput();
if (columns <= 0) IncorrectValue();
Console.Write("Введите глубину: ");
int depth = UserInput();
if (depth <= 0) IncorrectValue();
if (rows * columns * depth > 90)
{
    Console.WriteLine("Превышен размер массива");
    return;
}

int[] array1D = CreateTwoDigitNonRepeatingArray(rows * columns * depth);
int[] rndArray = CreateRndArray(array1D);
int[,,] array3D = Create3DArray(rows, columns, depth, rndArray);
Console.WriteLine();
Print3DArray(array3D);
