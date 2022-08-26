/*
Задача 34: 
Задайте массив заполненный случайными положительными 
трёхзначными числами. 
Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

int EnterNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

void CheckNumber(int checkNum)
{
    int count = 0;
    int checking = checkNum;
    while (checking != 0)
    {
        checking = checking / 10;
        count++;
    }
    if (count != 3)
    {
        Console.WriteLine($"Число {checkNum} не трёхзначное. Не совпадает с начальным условием.");
    }
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

int EventArrayCount(int[] arr)
{
    int evenCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) evenCount++;
    }
    return evenCount;
}

int numberN = EnterNumber("Введите размер массива (N):");
Console.WriteLine("Сформируем массив в интервале случайных чисел.");
int numberA = EnterNumber("Введите трёхзначное число начала интервала:");
CheckNumber(numberA);
int numberB = EnterNumber("Введите трёхзначное число конца интервала:");
CheckNumber(numberB);

int[] array = GetArray(numberN, numberA, numberB);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Количество чётных чисел: {EventArrayCount(array)}");