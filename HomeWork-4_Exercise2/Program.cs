/*
Задача 27: Напишите функцию и запустите ее, 
которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int EnterNumber()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

void SumNumber(int num)
{
    int result = 0;
    int check = num;
    while (check != 0)
    {
        result = result + check % 10;
        check = check / 10;
    }
    Console.WriteLine($"Сумма цифр в числе {num} = {result}");
}

int number = EnterNumber();
SumNumber(number);