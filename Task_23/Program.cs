// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введиту число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
int result = 0;

while (index <= N)
{
    Console.Write(index);
    result = index * index * index;
    index++;
    Console.WriteLine($" | {result,4} |");
}
