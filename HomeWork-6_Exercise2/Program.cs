/* Задача 43: 
Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения
 b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int EnterNumber(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

double[] IntersecYX(double b1, double k1, double b2, double k2)
{
    double[] pointIntersec = new double[2];
    pointIntersec[0] = (b2 - b1) / (k1 - k2);
    pointIntersec[1] = k1 * pointIntersec[0] + b1;
    return pointIntersec;
}

Console.Clear();
double b1 = Convert.ToDouble(EnterNumber("Введите число b1"));
double k1 = Convert.ToDouble(EnterNumber("Введите коэффициент k1"));
double b2 = Convert.ToDouble(EnterNumber("Введите число b2"));
double k2 = Convert.ToDouble(EnterNumber("Введите коэффициент k2"));

double[] dot = IntersecYX(b1, k1, b2, k2);
Console.WriteLine($"Координата: ({dot[0]:f1}; {dot[1]:f1})");
//Console.WriteLine($"Координата: ({String.Join(";", dot)})");