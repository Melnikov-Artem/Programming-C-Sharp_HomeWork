/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
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

int[,] SortArray(int[,] array)
{
    int[,] sortNewArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int tempElem = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tempElem;
                }
            }
            sortNewArray[i, j] = array[i, j];
        }
    }
    return sortNewArray;
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

int[,] newArray = SortArray(myArray);
PrintArray(newArray);