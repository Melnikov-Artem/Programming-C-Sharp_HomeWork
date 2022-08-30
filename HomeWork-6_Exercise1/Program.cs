/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int EnterNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int CountNumbers(int m, string message)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"{message}{i + 1}: ");
        if (Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    return count;
}

Console.Clear();
int numberM = EnterNumber("Укажите количество вводимых цифр M:");
int count = CountNumbers(numberM, "Введите число №");
Console.WriteLine($"Количество положительных чисел = {count}");