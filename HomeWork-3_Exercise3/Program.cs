/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.Write("Введите число, для которого будет выдаваться список возведения в 3-ю степень:");
int number = Convert.ToInt32(Console.ReadLine());
int i;

for (i = 1; i < number;)
{
    Console.Write(Math.Pow(i, 3) + ", ");
    ++i;
}
Console.WriteLine(Math.Pow(i,3));