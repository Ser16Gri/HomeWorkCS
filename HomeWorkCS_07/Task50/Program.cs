﻿// Task50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int i = ReadInt("Введите первую позицию:");
int j = ReadInt("Введите вторую позицию:");
Console.WriteLine();
int length = ReadInt("Длина m: ");
int secondLength = ReadInt("Длина n: ");
Console.WriteLine();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.WriteLine();
ElementValue(array);
Console.ReadLine();



int ReadInt(string argument)
{
    Console.Write($"{argument} ");
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ElementValue(int[,] array)
{
    if (i <= array.GetLength(0) && j <= array.GetLength(1))
    {
        Console.WriteLine($"Ваше число: {array[i, j]}");
    }
    else Console.WriteLine($"Такого числа нет в массиве");

}