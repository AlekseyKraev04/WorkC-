// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.WriteLine("Чтобы получить сумму цифр в числе:");
Console.Write("Введем число N:");
int N = Convert.ToInt32(Console.ReadLine());
int SumNum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

void PrintSumNum(int result)
{
    Console.Write($"Сумма цифр в числе N {N} равна : {result}");
}
int res = SumNum(N);
PrintSumNum(res);
