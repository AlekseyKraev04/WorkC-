// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();


Console.WriteLine("Зададим первое НЕОТРИЦАТЕЛЬНОЕ ЦЕЛОЕ число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Зададим второе НЕОТРИЦАТЕЛЬНОЕ ЦЕЛОЕ число: ");
int num2 = int.Parse(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, n = 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

void PrintSumNum(int result)
{
    Console.Write($"Функция Аккермана({num1}, {num2}) равна: {result}!");
}

int res = Ackermann(num1, num2);
PrintSumNum(res); 