// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.Write("Чтобы узнать является ли число палиндромом, введем пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введенное число не пятизначное ");
    return;
}

int[] array = new int[5];
int index = 0;
while (index <= 4)
{
    array[index] = num % 10;
    num = (num - array[index]) / 10;
    index++;
}
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}