/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int EnterNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int OddArraySum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) count+=arr[i];
    }
    return count;
}

int numberN = EnterNumber("Введите размер одномерного массива (N):");
Console.WriteLine("Сформируем массив в интервале случайных чисел.");
int numberA = EnterNumber("Введите число начала интервала:");
int numberB = EnterNumber("Введите число конца интервала:");

int[] array = GetArray(numberN, numberA, numberB);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма нечётных элементов массива: {OddArraySum(array)}");