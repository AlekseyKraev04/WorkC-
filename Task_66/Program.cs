// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Зададим первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Зададим второе число: ");
int num2 = int.Parse(Console.ReadLine());

int MatrixSumNumber(int number1, int number2)
{
    if (number1 == number2) return number1;
    else if (number1 < number2) return number1 + MatrixSumNumber(number1 + 1, number2);
    else return number1 + MatrixSumNumber(number1 - 1, number2);
}

void PrintSumNum(int result)
{
    Console.Write($"Сумма натуральных элементов в промежутке от {num1} до {num2} равна: {result}!");
}

int res = MatrixSumNumber(num1, num2);
PrintSumNum(res);