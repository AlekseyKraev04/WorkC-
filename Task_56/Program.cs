// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введем количество строк:");
int m = int.Parse(Console.ReadLine());

Console.Write("Введем количество столбцов:");
int n = int.Parse(Console.ReadLine());

Console.Write("Введем минимальное значение элементов массива:");
int min = int.Parse(Console.ReadLine());

Console.Write("Введем максимальное значение массива:");
int max = int.Parse(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int minimal, int maximal)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(minimal, maximal + 1);
        }
    }
    return arr;
}
int[] MatrixSumNumbers(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i, j];
        }
        result[i] = sum;
    }
    return result;
}
int SelectionMin(int[] array)
{
    int minPositioin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minPositioin])
        {
            minPositioin = i;
        }
    }
    return minPositioin + 1;
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Сумма чисел каждой строки: ");
        if (i < array.Length - 1) Console.Write(array[i] + ",  ");
        else Console.Write(array[i] + ".");
    }
    Console.WriteLine("\b");
}

if (m == n) Console.WriteLine("Введенный массив квадратный!");
else
{
    int[,] arrayResult = CreateMatrixRndInt(m, n, min, max);
    PrintMatrix(arrayResult);
    Console.WriteLine();
    int[] sumArrCol = MatrixSumNumbers(arrayResult);
    PrintArray(sumArrCol);

    int minNumberLineMatrix = SelectionMin(sumArrCol);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minNumberLineMatrix} строка");
}