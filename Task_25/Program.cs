// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Clear();

Console.WriteLine("Чтобы возвести число А в натуральную степень В:");
Console.Write("1. Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Введите натуральную степень В: ");
int B = Convert.ToInt32(Console.ReadLine());

int NatDegree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;
    }
    return result;
}

void PrintDegree (int Exp)
{
    Console.WriteLine($"Результат возведения числа A {A} в степень {B} равен {Exp}");
}
 int res = NatDegree(A, B);
 PrintDegree(res);