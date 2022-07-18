// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();

Console.WriteLine("Чтобы создать массив следуйте инструкциям!");

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

int[] CreateArrayRndInt(int sizeArray, int minimal, int maximum)
{
    int[] array = new int[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = rnd.Next(minimal, maximum + 1);
    }
    return array;
}

int SumAddArrayNumbers(int[] array)
{
    int sumAddArrNum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sumAddArrNum = sumAddArrNum + array[i];
    }
    return sumAddArrNum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.WriteLine(array[i] + "]");

    }
}

int[] array = CreateArrayRndInt(sizeArr, min, max);
PrintArray(array);
int resultSum = SumAddArrayNumbers(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {resultSum}");
Console.WriteLine("\b");



