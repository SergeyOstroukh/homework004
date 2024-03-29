﻿// Задача 27.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sum(int num)
{
    int nextNum = 0;
    int result = 0;
    while (num > 0)
    {
        nextNum = num % 10;
        num = num / 10;
        result = result + nextNum;
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) number = number * -1;
Console.WriteLine($"Сумма цифр числа {number} равна {Sum(number)}");
