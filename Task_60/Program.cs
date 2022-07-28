// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();


Console.Write("Введем размрер массива по оси Х: ");
int line = int.Parse(Console.ReadLine());

Console.Write("Введем размрер массива по оси Y: ");
int column = int.Parse(Console.ReadLine());

Console.Write("Введем размрер массива по оси Z: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введем минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введем максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

int[] CreateNumberRandomArray(int line, int column, int size, int minimal, int maximal)
{
    Random rnd = new Random();
    int num = 0;
    int[] array = new int[line * column * size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minimal, maximal + 1);
        num = array[i];
        for (int j = 0; j < i; j++)
        {
            while (array[i] == array[j])
            {
                array[i] = rnd.Next(minimal, maximal + 1);
                j = 0;
                num = array[i];
            }
            num = array[i];
        }
    }
    return array;
}

int[,,] ArrayinDataCube(int[] inArray, int line, int column, int size)
{
    int[,,] dataCube = new int[line, column, size];
    int count = 0;
    for (int i = 0; i < dataCube.GetLength(0); i++)
    {
        for (int j = 0; j < dataCube.GetLength(1); j++)
        {
            for (int k = 0; k < dataCube.GetLength(2); k++)
            {
                dataCube[i, j, k] = inArray[count];
                count++;
            }
        }
    }
    return dataCube;
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

void PrintDataCube(int[,,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            for (int k = 0; k < data.GetLength(2); k++)
            {
                Console.Write($"({i}, {j}, {k}){data[i, j, k],2}   ");
            }
        }
        Console.WriteLine();
    }
}

int[] arrayNew = CreateNumberRandomArray(line, column, size, min, max);
Console.WriteLine("Трехмерный массив переведен в одномерный:");
PrintArray(arrayNew);

int[,,] dataResult = ArrayinDataCube(arrayNew, line, column, size);
Console.WriteLine("Трехмерный массив:");
PrintDataCube(dataResult);
Console.WriteLine();
