// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[] FindElement(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        double count = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum = sum + inArray[i, j];
            count++;
        }
        result[j] = Math.Round(sum / count, 2);
    }
    return result;
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Среднее арифметическое столбцов: ");
        if (i < array.Length - 1) Console.Write(array[i] + ",  ");
        else Console.Write(array[i] + ".");
    }
    Console.WriteLine("\b");
}

int[,] array = CreateMatrixRndInt(m, n, min, max);
PrintMatrix(array);
Console.WriteLine();
double[] result = FindElement(array);
PrintArray(result);