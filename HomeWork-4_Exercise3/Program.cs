/*
Задача 29: Напишите программу, 
которая задаёт массив из N элементов, 
заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]
*/

Console.Clear();

int EnterNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayRandom(int N, int minValue, int maxValue)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

void PrintArray(int[] arrayPrint)
{
    int count = arrayPrint.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arrayPrint[i]} ");
    }
    Console.WriteLine();
}


int numberN = EnterNumber("Определим длину массива, введите число N:");
int numberA = EnterNumber("Для начального значения введите число A:");
int numberB = EnterNumber("Для конечного значения введите число B:");

int[] array = ArrayRandom(numberN, numberA, numberB);
PrintArray(array);
