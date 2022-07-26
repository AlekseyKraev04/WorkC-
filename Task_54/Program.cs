// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1

// 9 5 3 2

// 8 4 4 2

Console.Clear();

Console.Write("Введем количество строк:");
int line = int.Parse(Console.ReadLine());

Console.Write("Введем количество столбцов:");
int column = int.Parse(Console.ReadLine());

Console.Write("Введем минимальное значение элементов массива:");
int min = int.Parse(Console.ReadLine());

Console.Write("Введем максимальное значение массива:");
int max = int.Parse(Console.ReadLine());

int[,] CreateMatrixRndInt(int line, int column, int minimal, int maximal)
{
    int[,] arr = new int[line, column];
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
int[] MatrixinSortArray(int[,] in_matrix)
{
    int[] arrayForMethod = new int[in_matrix.Length];
    int count = 0;
    for (int i = 0; i < in_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < in_matrix.GetLength(1); j++)
        {
            arrayForMethod[count] = in_matrix[i, j];
            count++;
        }
    }
    Array.Sort(arrayForMethod);
    return arrayForMethod;
}

int[,] SortArrayinMatrix(int[] sortArray)
{
    int[,] sortMatrix = new int[line, column];
    int count = 0;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sortMatrix[i, j] = sortArray[count];
            count++;
        }
    }
    return sortMatrix;
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
        if (i == 0) Console.Write("Одномерный массив: ");
        if (i < array.Length - 1) Console.Write(array[i] + ",  ");
        else Console.Write(array[i] + ".");
    }
    Console.WriteLine("\b");
}

int[,] arrayResult = CreateMatrixRndInt(line, column, min, max);
Console.WriteLine("Двумерный массив:");
PrintMatrix(arrayResult);
Console.WriteLine();

int[] sortArray = MatrixinSortArray(arrayResult);
Console.WriteLine("Двумерный массив переведен в одномерный и отсортирован:");
PrintArray(sortArray);

int[,] sortMatrix = SortArrayinMatrix(sortArray);
Console.WriteLine("Отсортированный двумерный массив:");
PrintMatrix(sortMatrix);