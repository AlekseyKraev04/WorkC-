// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

Console.WriteLine("Чтобы создать массив следуйте инструкциям!");

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

double[] CreateArrayRndInt(int sizeArray, int minimal, int maximum)
{
    double[] array = new double[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (maximum-minimal)+minimal), 2);
    }
    return array;
}

double SelectiontMin(double[] array)
{
    int minPositioin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minPositioin])
        {
            minPositioin = i;
        }
    }
    return array[minPositioin];
}

double SelectionMax(double[] array)
{
    int maxPositioin = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] > array[maxPositioin])
        {
            maxPositioin = i;
        }
    }
    return array[maxPositioin];
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",  ");
        else Console.Write(array[i] + "]");
    }
    Console.WriteLine("\b");
}

double[] array = CreateArrayRndInt(sizeArr, min, max);
PrintArray(array);

SelectiontMin(array);
var minnum = SelectiontMin(array);
Console.WriteLine($"Минимальное значение в массиве: {minnum}");

SelectionMax(array);
var maxnum = SelectionMax(array);
Console.WriteLine($"Максимальное значение в массиве: {maxnum}");

double result = SelectionMax(array) - SelectiontMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");

