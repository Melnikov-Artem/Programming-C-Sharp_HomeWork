/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
m = 2, n = 3 -> A(m,n) = 9
*/

int ReadWriteMss(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    else
        if (m > 0 && n == 0) return AkkermanRec(m - 1, 1);
    else return AkkermanRec(m - 1, AkkermanRec(m, n - 1));
}

Console.Clear();
int mNumber = ReadWriteMss("Введите число M: ");
int nNumber = ReadWriteMss("Введите число N: ");
int result = AkkermanRec(mNumber, nNumber);
Console.WriteLine($"Значение функции Аккермана: {result}");