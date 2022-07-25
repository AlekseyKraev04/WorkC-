// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введем количество строк:");
int m = int.Parse(Console.ReadLine());

Console.Write("Введем количество столбцов:");
int n = int.Parse(Console.ReadLine());

Console.Write("Введем минимальное значение элементов массива:");
int min = int.Parse(Console.ReadLine());

Console.Write("Введем максимальное значение массива:");
int max = int.Parse(Console.ReadLine());

double[,] CreateMatrixRndDouble(int m, int n, int minimal, int maximal)
{
    double[,] arr = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            arr[i, j] = Math.Round(rnd.Next(min, max) +rnd.NextDouble(),1);

        }

    }
    return arr;
}
void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4} |");
            else Console.Write($"{arr[i, j],4} |");
        }
        Console.WriteLine();
    }
}

double[,] array = CreateMatrixRndDouble(m, n, min, max);
PrintMatrix(array);