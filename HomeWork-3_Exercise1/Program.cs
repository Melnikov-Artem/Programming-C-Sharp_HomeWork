/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, 
исключительно работа с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.Write("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
bool check1 = Convert.ToBoolean(number / 10000); // проверка числа на 5 разрядов
bool check2 = Convert.ToBoolean(number / 100000); // проверка числа на большее, чем 5 разрядов

int x1 = number / 10000;
int y1 = number / 1000 % 10;
int x2 = number % 10;
int y2 = number % 100 / 10;

if (check1 && !check2)
{
    if (x1 == x2 && y1 == y2)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Число не пятизначное!");
}