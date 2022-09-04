/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/

int ReadWriteMss(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetArray(int numX, int numY, int numZ, int minVal, int maxVal)
{
    int[,,] array = new int[numX, numY, numZ];
    for (int ln = 0; ln < array.GetLength(0); ln++)
    {
        for (int str = 0; str < array.GetLength(1); str++)
        {
            for (int col = 0; col < array.GetLength(2); col++)
            {
                array[ln, str, col] = new Random().Next(minVal, maxVal + 1);
            }

        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"\t {array[j, k, i]}({j},{k},{i})");
            }
            Console.WriteLine();
            }
        }
    }

    Console.Clear();
    int str = ReadWriteMss("Введите первую размерность массива: ");
    int col = ReadWriteMss("Введите вторую размерность массива: ");
    int ln = ReadWriteMss("Введите третью размерность массива: ");
    Console.WriteLine("Сформируем массив в интервале случайных чисел.");
    int numMin = ReadWriteMss("Введите число начала интервала:");
    int numMax = ReadWriteMss("Введите число конца интервала:");
    Console.WriteLine();

    int[,,] myArray = GetArray(str, col, ln, numMin, numMax);
    PrintArray(myArray);
    Console.WriteLine("------");