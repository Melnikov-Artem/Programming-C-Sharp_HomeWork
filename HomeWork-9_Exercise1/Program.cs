/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int ReadWriteMss(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int SumElem(int M, int N)
{
    if (M >= N) return M;
    return M + SumElem(M + 1, N);
}

int SumElemX(int M, int N)
{
    if (N < M) return N;
    return N + SumElem(M, N - 1);
}

int SumElemXX(int M, int N)
{
    return N < M ? M : N + SumElem(M, N - 1);
}

Console.Clear();
Console.WriteLine("Найдём сумму натуральных элементов в промежутке от M до N.");
int mNumber = ReadWriteMss("Введите число M: ");
int nNumber = ReadWriteMss("Введите число N: ");
int result = SumElem(mNumber, nNumber);
Console.WriteLine($"Вариант решения №1:\n {result}");
Console.WriteLine($"Вариант решения №2:\n {SumElemX(mNumber, nNumber)}");
Console.WriteLine($"Вариант решения №3:\n {SumElemXX(mNumber, nNumber)}");