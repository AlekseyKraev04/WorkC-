// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Вводим число");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 99) Console.WriteLine("Третьей цифры нет");
else
{
    int third = ThirdDigit(a);
    Console.WriteLine($"Третья цифра введенного числа {third % 10}");

}

int ThirdDigit(int num)
{
    while (num > 1000) num = num / 10;
    return num;
}