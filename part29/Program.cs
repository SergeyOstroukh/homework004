﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
//int[] array = new int[];
int[] CreateArray(int size, int minimal, int maximal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(minimal, maximal);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;

    while (position < count)
    {
        if (position < count - 1) Console.Write($"{array[position]}, ");
        else
            Console.Write($"{array[position]}");
        position++;
    }

}
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(sizeArray, minNum, maxNum);
PrintArray(arr);
Console.Write(" --> ");
Console.Write("[");
PrintArray(arr);
Console.Write("]");
