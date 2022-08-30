/* Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintNewArray(double[] array)
{
    int i=0;
    for (i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]:f1}"+ "; ");
    }
    double tempNum=array[i];
    Console.WriteLine($"{tempNum:f1}" + ".");
}

double[] AverageColumn(int[,] array)
{
    double result = 0.0;
    double[] resArray=new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        result /= array.GetLength(0);
        resArray[i]=result;
        result=0;
    }
    return resArray;
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

double[] newArray = AverageColumn(myArray);
PrintNewArray(newArray);