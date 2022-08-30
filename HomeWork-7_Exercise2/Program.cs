/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет
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
            array[str, col] = new Random().Next(minVal, maxVal);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindArrayElement(int numStr, int numCol, int[,] findArray)
{
    int numElemStr = -1;
    int numElemCol = -1;
    for (int i = 0; i < findArray.GetLength(0); i++)
    {
        for (int j = 0; j < findArray.GetLength(1); j++)
        {
            if (i == numStr && j == numCol)
            {
                numElemStr = i;
                numElemCol = j;
            }
        }
    }
    if (numElemStr >= 0)
        Console.WriteLine($"Поисковый элемент = {findArray[numElemStr, numElemCol]}");
    else
        Console.WriteLine($"Такого числа в массиве нет.");
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
int N = ReadWriteMss("Введите № строки элемента для поиска N: ") - 1;
int M = ReadWriteMss("Введите № столбца элемента для поиска M: ") - 1;
FindArrayElement(N, M, myArray);