/* Задача 47. 
Задайте двумерный массив размером m?n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int EnterIntNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetArray(int strings, int columns, int minValue, int maxValue)
{
    double[,] result = new double[strings, columns];
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = new Random().Next(minValue, maxValue-1) + new Random().NextDouble();
          //  result[i, j] = new Random().NextDouble(minValue, maxValue + 1);
    return result;
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]:F1} ");
        Console.WriteLine();
    }
}

Console.Clear();
int numStr = EnterIntNumber("Введите количество строк массива:");
int numCol = EnterIntNumber("Введите количество столбцов массива:");
Console.WriteLine("Сформируем массив в интервале случайных чисел.");
int numMin = EnterIntNumber("Введите число начала интервала:");
int numMax = EnterIntNumber("Введите число конца интервала:");
Console.WriteLine("------");
double[,] array = GetArray(numStr, numCol, numMin, numMax);
PrintArray(array);
Console.WriteLine("------");