/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
*/

int ReadWriteMss(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray(int numStr, int numCol, int minVal, int maxVal)
{
    int[,] array = new int[numStr, numCol];
    for (int str = 0; str < array.GetLength(0); str++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[str, col] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] CountSumStr(int[,] array)
{
    int sum = 0;
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newArray[i] = sum;
        sum = 0;
    }
    return newArray;
}

void FindMinSumStr(int[] array)
{
    int minStr = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minStr])
        {
            minStr = i;
        }
    }
    Console.Write("Строки с наименьшей суммой: ");
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] == array[minStr])
            Console.Write((j + 1) + ", ");
    }
    Console.WriteLine();
}

Console.Clear();
int n = ReadWriteMss("Введите количество строк массива: ");
int m = ReadWriteMss("Введите количество столбцов массива: ");
Console.WriteLine("Сформируем массив в интервале случайных чисел.");
int numMin = ReadWriteMss("Введите число начала интервала:");
int numMax = ReadWriteMss("Введите число конца интервала:");
Console.WriteLine();

int[,] myArray = GetArray(n, m, numMin, numMax);
PrintArray(myArray);
Console.WriteLine();

int[] newArray = CountSumStr(myArray);
FindMinSumStr(newArray);