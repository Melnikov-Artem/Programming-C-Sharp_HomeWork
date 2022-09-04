/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
*/

int ReadWriteMss(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
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

int[,] NewGetArray(int numString, int numColumn, int startNum)
{
    int numStr = numString-1;
    int numCol = numColumn-1;
    int minStr = 0;
    int minCol = 0;
    int[,] newArray = new int[numString, numColumn];
    int flagDirection = 1;
    while ((numStr - minStr >= 0) && (numCol - minCol >= 0))
    {
        switch (flagDirection)
        {
            case 1:
                {
                    for (int i = minCol; i <= numCol; i++)
                    {
                        newArray[minStr, i] = startNum;
                        startNum++;
                    }
                    minStr++;
                    flagDirection = 2;
                    break;
                }
            case 2:
                {
                    for (int i = minStr; i <= numStr; i++)
                    {
                        newArray[i, numCol] = startNum;
                        startNum++;
                    }
                    numCol--;
                    flagDirection = 3;
                    break;
                }
            case 3:
                {
                    for (int i = numCol; i >= minCol; i--)
                    {
                        newArray[numStr, i] = startNum;
                        startNum++;
                    }
                    numStr--;
                    flagDirection = 4;
                    break;
                }
            case 4:
                {
                    for (int i = numStr; i >= minStr; i--)
                    {
                        newArray[i, minCol] = startNum;
                        startNum++;
                    }
                    minCol++;
                    flagDirection = 1;
                    break;
                }
            default:
                {
                    Console.WriteLine("Что-то пошло не так");
                    break;
                }
        }
    }
    return newArray;
}

Console.Clear();
int n = ReadWriteMss("Введите количество строк массива: ");
int m = ReadWriteMss("Введите количество столбцов массива: ");
int startNumber = ReadWriteMss("Введите стартовое число:");
Console.WriteLine();

int[,] myArray = NewGetArray(n, m, startNumber);
Console.WriteLine();
PrintArray(myArray);