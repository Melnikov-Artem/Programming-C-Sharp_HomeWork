/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить 
произведение двух матриц.
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] array1, int[,] array2)
{
    int numStr1 = array1.GetLength(0);
    int numCol1 = array1.GetLength(1);
    int numStr2 = array2.GetLength(0);
    int numCol2 = array2.GetLength(1);
    int[,] resArray = new int[numStr1, numCol2];

    if (numCol1 == numStr2)
    {
        // int[,] resArray = new int[numStr1, numCol2];
        int sumElem = 0;
        for (int i = 0; i < numStr1; i++)
        {
            for (int l = 0; l < numCol2; l++)
            {
                for (int j = 0; j < numCol1; j++)
                {
                    sumElem += array1[i, j] * array2[j, l];
                }
                resArray[i,l]=sumElem;
                sumElem =0;

            }

        }

    }
    else
    {
        Console.WriteLine("Произведение матриц невозможно!");
    }
    return resArray;
}

Console.Clear();
int str1 = ReadWriteMss("Введите количество строк 1-й матрицы: ");
int col1 = ReadWriteMss("Введите количество столбцов 1-й матрицы: ");
int str2 = ReadWriteMss("Введите количество строк 2-й матрицы: ");
int col2 = ReadWriteMss("Введите количество столбцов 2-й матрицы: ");
Console.WriteLine("Сформируем массив в интервале случайных чисел.");
int numMin = ReadWriteMss("Введите число начала интервала:");
int numMax = ReadWriteMss("Введите число конца интервала:");
Console.WriteLine();

int[,] myArray1 = GetArray(str1, col1, numMin, numMax);
int[,] myArray2 = GetArray(str2, col2, numMin, numMax);
PrintArray(myArray1);
Console.WriteLine("------");
PrintArray(myArray2);
Console.WriteLine("------");
Console.WriteLine("Результат произведения 2-х матриц:");
int[,] newArray = MultiMatrix(myArray1, myArray2);
PrintArray(newArray);