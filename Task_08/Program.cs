// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Нужно определить четные числа от 1 до N:");

Console.WriteLine("Вводим целое число N:");
int num1 = Convert.ToInt32(Console.ReadLine());

String result = string.Empty;

for (int i = 2; i <= num1; i += 2)
{
    result = result + " " + i;
}
Console.WriteLine("Четные числа от 0 до N: " +result);
