/* Семинар 6 задача со*: 
Напишите программу, которая реализует обход введенного 
двумерного массива, начиная с крайнего нижнего 
левого элемента против часовой стрелки.

1 2 3
4 5 6 -> 7 8 9 6 3 2 1 4 5
7 8 9
*/

int EnterNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray(int strings, int columns, int minValue, int maxValue)
{
    int[,] result = new int[strings, columns];
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
    return result;
}

string NewString(int[,] myArray)
{
    int numStr = myArray.GetLength(0);
    int numCol = myArray.GetLength(1);
    int minStr = 0;
    int minCol = 0;
    int flagDirection = 0;
    bool flagCorrect = false;
    string resultStr = String.Empty;
    while ((numStr - minStr > 0) || (numCol - minCol > 0))
    {
        switch (flagDirection)
        {
            case 1:
                {
                    for (int i = minCol; i < numCol; i++)
                    {
                        resultStr = string.Join(" ", myArray[numStr, i]);
                        Console.WriteLine(myArray[numStr, i]);
                    }
                    minStr++;
                    flagDirection = 2;
                    Console.WriteLine();
                    break;
                }
            case 2:
                {
                    for (int i = numStr; i > minStr; i--)
                    {
                        resultStr = string.Join(" ", myArray[i, numCol]);
                    }
                    if (flagCorrect) minCol++;
                    flagDirection = 3;
                    break;
                }
            case 3:
                {
                    for (int i = numCol; i > minCol; i--)
                    {
                        resultStr = string.Join(" ", myArray[minStr, i]);
                    }
                    numStr--;
                    flagDirection = 4;
                    flagCorrect = true;
                    break;
                }
            case 4:
                {
                    for (int i = minStr; i > numStr; i++)
                    {
                        resultStr = string.Join(" ", myArray[i, minCol]);
                    }
                    numCol--;
                    flagDirection = 1;
                    break;
                }
            default:
                {
                    for (int i = minCol; i < numCol; i++)
                    {
                        resultStr = string.Join(" ", myArray[numStr, i]);
                    }
                    flagDirection = 2;
                    break;
                }
        }
    }
    return resultStr;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.Clear();
int numStr = EnterNumber("Введите количество строк массива:");
int numCol = EnterNumber("Введите количество столбцов массива:");
Console.WriteLine("Сформируем массив в интервале случайных чисел.");
int numMin = EnterNumber("Введите число начала интервала:");
int numMax = EnterNumber("Введите число конца интервала:");
Console.WriteLine("------");
int[,] array = GetArray(numStr, numCol, numMin, numMax);
PrintArray(array);
Console.WriteLine("------");
Console.WriteLine($"Новый ряд чисел: {NewString(array)}");