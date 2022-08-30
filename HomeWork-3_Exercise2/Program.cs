/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
Console.Write("Введите координату X1 для первой точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1 для первой точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1 для первой точки:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2 для второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2 для второй точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2 для второй точки:");
int z2 = Convert.ToInt32(Console.ReadLine());

double mult = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);
//double distance = Math.Pow(mult,0.5);
Console.WriteLine($"{Math.Pow(mult,0.5):f2}");