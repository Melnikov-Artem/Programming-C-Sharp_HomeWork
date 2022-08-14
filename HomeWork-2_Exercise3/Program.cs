/*
Задача 15:  Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
string answer = "нет";

if (0 < number && number< 8)
{
    if (number == 6 || number == 7)
    {
        answer = "да";
    }
    Console.WriteLine(answer);
}
else
{
    Console.WriteLine("Дня недели с таким номером не существует.");
}