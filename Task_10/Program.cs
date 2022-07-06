// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Вводим трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    return num / 10 % 10
}
if (a / 100 > 0 && a / 100 < 10) Console.WriteLine(SecondDigit(a));
else Console.WriteLine("ВВедено некоректное число");