// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Чтобы увидеть какое число больше, а какое меньше");

Console.WriteLine("Введите два целых числа");
string[ ] nums = Console.ReadLine().ToString().Split(' ');
int num1 = Convert.ToInt32(nums[0]);
int num2 = Convert.ToInt32(nums[1]);
if (num1 == num2)
{
    Console.WriteLine(String.Format("Первое число {0} ,больше второго числа{1}", num1, num2));
    Console.WriteLine(String.Format("Первое число {1} ,меньше первого числа{0}", num1, num2));
}
else if (num1 == num2)
{
    Console.WriteLine(String.Format("Первое число {0} ,равно второму числу{1}", num1, num2));
}
else
{
Console.WriteLine(String.Format("Первое число {0} ,меньше второго числа{1}", num1, num2));
 Console.WriteLine(String.Format("Первое число {1} ,больше первого числа{0}", num1, num2));

}