/*
Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Реализовать функцию возведения в степень самостоятельно!
*/

Console.Clear();
int EnterNumber(string msg)
{
Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}

void NumberPower(int numA, int numB)
{
    int result =1;
    if (numB !=0)
    {
        for (int i = 1; i <= numB; i++)
        {
            result*=numA;
        }
    }
    Console.WriteLine($"Число {numA} в степени {numB} = {result}");
}

Console.WriteLine("Введите последовательно 2 числа");
int numberA = EnterNumber("• введите число A:");
int numberB = EnterNumber("• введите число B:");

NumberPower(numB: numberB, numA: numberA);