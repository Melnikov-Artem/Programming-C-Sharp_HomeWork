/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();

int EnterIntNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

double MinArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double DiffMinMax(double minNumber, double maxNumber)
{
    double res = maxNumber - minNumber;
    return res;
}

int numberN = EnterIntNumber("Введите размер одномерного массива (N):");

double[] array = GetArray(numberN);
Console.WriteLine(String.Join(" ", array));
double result = DiffMinMax(MinArray(array), MaxArray(array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");