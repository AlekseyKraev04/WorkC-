// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Вводим любое количество целых чисел через запятую:");
string[] userNumbers = Console.ReadLine().Split(',');

int NumbersGreaterZero(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int number = Convert.ToInt32(array[i]);
        if (number > 0) count++;
    }
    return count;
}

NumbersGreaterZero(userNumbers);
int result = NumbersGreaterZero(userNumbers);
Console.WriteLine($"Результат {result} чисел больше 0!");